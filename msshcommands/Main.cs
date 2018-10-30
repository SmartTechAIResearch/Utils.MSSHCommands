/*
    Dieter Vandroemme
    2018
    MIT License

    A small tool to send a ssh command to multiple devices at the same time.

 */

using Renci.SshNet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msshcommands {
    /// <summary>
    /// A small tool to send a ssh command to multiple devices at the same time.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Main : Form {
        private string _regexIPv4 = "((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
        private SynchronizationContext _synchronizationContext;
        private ConcurrentDictionary<string, SshClient> _clients = new ConcurrentDictionary<string, SshClient>();

        private CommandHistory _commandHistory = CommandHistory.GetInstance();
        private bool _controlPressed;

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        string[] _ipsAndHosts;
        private int _commandsSend;
        private Thread[] _pool;
        private ManualResetEvent _startSendCommandWaitHandle = new ManualResetEvent(false);

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main() {
            InitializeComponent();
            if (this.IsHandleCreated) {
                Init();
            }
            else {
                this.HandleCreated += Main_HandleCreated;
            }
        }

        private void Main_HandleCreated(object sender, EventArgs e) {
            this.HandleCreated -= Main_HandleCreated;
            Init();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            _startSendCommandWaitHandle.Set();
            _cancellationTokenSource.Cancel();
            DisposeSshClients();

            Properties.Settings.Default.Save();
        }

        private void Init() { _synchronizationContext = SynchronizationContext.Current; }

        private void chkAutomation_CheckedChanged(object sender, EventArgs e) {
            chkAutomation.ForeColor = chkAutomation.Checked ? Color.Green : Color.Gray;
        }
        private void btnAutomation_Click(object sender, EventArgs e) {
            var automation = new Automation();
            automation.ShowDialog();
            chkAutomation.Checked = true;
        }

        private void btnSSHCommand_Click(object sender, EventArgs e) {
            if (btnSSHCommand.Text == "SSH command:") {
                SendSSHCommand();
            }
            else {
                CancelSSHCommand();
            }

            txtSSHCommand.Focus();
        }

        private void SendSSHCommand() {
            string command = txtSSHCommand.Text.Trim();
            if (command.Length == 0) return;

            if (chkAutoClearLog.Checked) rtxtLog.Text = "";

            if (_commandHistory.Count == 0 || txtSSHCommand.Text != _commandHistory.Last.Value) {
                _commandHistory.CurrentCommandHistoryNode = _commandHistory.AddLast(command);
            }
            if (_commandHistory.Count > 200) _commandHistory.RemoveFirst();

            command = command.Replace("\r", "");

            int port = Convert.ToInt32(nudPort.Value);
            string user = txtUser.Text.Trim();
            string password = txtPassword.Text;

            PrivateKeyFile pkf = null;

            string privateKeyFile = txtPrivateKeyFile.Text.Trim();
            string passphrase = txtPassphrase.Text;

            if (privateKeyFile.Length != 0) {
                try {
                    if (passphrase.Length == 0) {
                        pkf = new PrivateKeyFile(privateKeyFile);
                    }
                    else {
                        pkf = new PrivateKeyFile(privateKeyFile, passphrase);
                    }
                }
                catch {
                    Log("Failed loading private key fail. Falling back on password.");
                }
            }

            int timeout = Convert.ToInt32(nudTimeout.Value);
            bool keepAlive = chkKeepAlive.Checked;

            if (txtIPsHosts.Text.Trim().Length == 0 || user.Length == 0 || (password.Length == 0 && pkf == null) || command.Length == 0) {
                Log("Cannot send a command if not all required fields are filled in.");
            }
            else {
                btnSSHCommand.Text = "Cancel";
                nudTimeout.Enabled = chkKeepAlive.Enabled = false;

                _ipsAndHosts = GetIPsAndHosts();
                _commandsSend = 0;

                //ThreadPool is used in SSH.NET to queue connection handshake actions. So instead of queueing following on the same thread pool --> Own thread pool implementation.
                ThreadPool.SetMaxThreads(int.MaxValue, int.MaxValue);

                Log("^----- Connecting and sending -----^ @ " + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "\n");

                _pool = new Thread[_ipsAndHosts.Length];
                _startSendCommandWaitHandle.Reset();

                for (int i = 0; i != _ipsAndHosts.Length; i++) {
                    var t = new Thread(new ParameterizedThreadStart(SendSSHCommand_Callback));
                    t.IsBackground = true;
                    _pool[i] = t;

                    t.Start(new object[] { i, _ipsAndHosts.Length, _ipsAndHosts[i], port, user, pkf, password, command, timeout, keepAlive });
                }

                _startSendCommandWaitHandle.Set();
            }
        }

        private void SendSSHCommand_Callback(object state) {
            _startSendCommandWaitHandle.WaitOne();

            var args = state as object[];

            int i = (int)args[0];
            int size = (int)args[1];
            string ipOrHost = args[2].ToString();
            int port = (int)args[3];
            string user = args[4].ToString();
            var pkf = args[5] as PrivateKeyFile;
            string password = args[6].ToString();
            string command = args[7].ToString();
            var timeout = TimeSpan.FromSeconds((int)args[8]);
            bool keepAlive = (bool)args[9];

            //Try 2 times
            for (int t = 1; ; t++) {
                SshClient client = null;
                try {
                    _clients.TryGetValue(ipOrHost, out client);

                    if (client == null) {
                        client = pkf == null ? new SshClient(ipOrHost, port, user, password) : new SshClient(ipOrHost, port, user, pkf);
                    }
                    client.ConnectionInfo.Timeout = timeout;

                    if (!_cancellationTokenSource.Token.IsCancellationRequested) {
                        if (!client.IsConnected) client.Connect();
                        if (!client.IsConnected) throw new Exception("Failed to connect");
                    }

                    if (!_cancellationTokenSource.Token.IsCancellationRequested) {
                        SshCommand sshc = client.CreateCommand(command);
                        sshc.CommandTimeout = timeout;

                        string result = sshc.Execute();

                        if (string.IsNullOrWhiteSpace(result)) result = "OK";

                        _synchronizationContext.Send((state2) => { Log(state2.ToString()); }, "  " + i + " / " + size + " - " + ipOrHost + "\t- " + result);

                        if (keepAlive) _clients.TryAdd(ipOrHost, client); else DisposeAndForgetSshClient(ipOrHost, client);
                    }
                    break;
                }
                catch (Exception ex) {
                    if (_cancellationTokenSource.IsCancellationRequested) {
                        break;
                    }
                    else {
                        if (t == 2) //Try 2 times
                            _synchronizationContext.Post((state2) => { Log(state2.ToString()); }, "  " + i + " / " + size + " - " + ipOrHost + "\t- " + ex.Message.Replace("\n", " ").Replace("\r", " ").Replace("\t", " "));
                        else
                            DisposeAndForgetSshClient(ipOrHost, client);
                    }
                }
            }

            if (Interlocked.Increment(ref _commandsSend) >= _ipsAndHosts.Length) {
                _synchronizationContext.Post((state2) => {
                    btnSSHCommand.Enabled = true;
                    btnSSHCommand.Text = "SSH command:";
                    nudTimeout.Enabled = chkKeepAlive.Enabled = true;
                    _cancellationTokenSource = new CancellationTokenSource();

                    Log("\nv-----          Done          -----v @ " + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + "\n");
                }, null);
            }
        }

        private void CancelSSHCommand() {
            if (MessageBox.Show("Cancelling will close all SSH connections.\nAre you sure that you want to to this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                btnSSHCommand.Enabled = false;
                _startSendCommandWaitHandle.Set();
                _cancellationTokenSource.Cancel();
                DisposeSshClients();
            }
        }
        private void chkKeepAlive_CheckedChanged(object sender, EventArgs e) {
            if (!chkKeepAlive.Checked) {
                DisposeSshClients();
                _clients = new ConcurrentDictionary<string, SshClient>();

                btnSSHCommand.Text = "SSH command:";
            }
        }

        private void DisposeSshClients() {
            foreach (var client in _clients.Values) {
                try {
                    client.Dispose();
                }
                catch {
                    //Don't care.
                }
            }
            _clients = new ConcurrentDictionary<string, SshClient>();
        }

        private void DisposeAndForgetSshClient(string ipOrHost, SshClient client) {
            SshClient stub;
            if (_clients.TryRemove(ipOrHost, out stub))
                try {
                    stub.Dispose();
                    stub = null;
                }
                catch {
                    //Don't care.
                }

            if (client != null)
                try {
                    client.Dispose();
                    client = null;
                }
                catch {
                    //Don't care.
                }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey) _controlPressed = true;
            else if (_controlPressed && e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }
        private void txtIPsHosts_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey) {
                _controlPressed = false;
            }
            else if (_controlPressed && e.KeyCode == Keys.A) txtIPsHosts.SelectAll();
        }
        private void txtSSHCommand_KeyUp(object sender, KeyEventArgs e) {
            if (_commandHistory.CurrentCommandHistoryNode == null) _commandHistory.CurrentCommandHistoryNode = _commandHistory.Last;
            if (e.KeyCode == Keys.ControlKey) {
                _controlPressed = false;
            }
            else {
                if (_controlPressed) {
                    if (e.KeyCode == Keys.A) {
                        txtSSHCommand.SelectAll();
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Enter) {
                        e.Handled = true;
                        btnSSHCommand.PerformClick();
                    }
                    else if (e.KeyCode == Keys.R) {
                        _controlPressed = false;
                        var history = new History();
                        history.SelectedValueChanged += History_SelectedValueChanged;
                        history.ShowDialog();
                        e.Handled = true;
                    }
                    else if (_commandHistory.CurrentCommandHistoryNode != null) {
                        if (e.KeyCode == Keys.Up && _commandHistory.CurrentCommandHistoryNode.Previous != null) {
                            string command = txtSSHCommand.Text.Trim();
                            if (command.Length == 0) return;
                            if (_commandHistory.CurrentCommandHistoryNode == _commandHistory.First) return;

                            _commandHistory.CurrentCommandHistoryNode = _commandHistory.CurrentCommandHistoryNode.Previous;
                            txtSSHCommand.Text = _commandHistory.CurrentCommandHistoryNode.Value;
                            e.Handled = true;
                        }
                        else if (e.KeyCode == Keys.Down && _commandHistory.CurrentCommandHistoryNode.Next != null) {
                            string command = txtSSHCommand.Text.Trim();
                            if (command.Length == 0) return;
                            if (_commandHistory.CurrentCommandHistoryNode == _commandHistory.Last) return;

                            _commandHistory.CurrentCommandHistoryNode = _commandHistory.CurrentCommandHistoryNode.Next;
                            txtSSHCommand.Text = _commandHistory.CurrentCommandHistoryNode.Value;

                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void History_SelectedValueChanged(object sender, EventArgs e) {
            txtSSHCommand.Text = (sender as History).SelectedValue;
        }

        private void Log(string s) { rtxtLog.Text = s.TrimEnd() + "\n" + rtxtLog.Text; }
        private string[] GetIPsAndHosts() {
            var ipsAndHosts = new HashSet<string>();

            string[] split = txtIPsHosts.Text.Split('\n', '\r', ' ', '\t');
            foreach (string s in split) {
                if (s.Length != 0) {
                    if (s.Contains("->")) {
                        var range = s.Split(new string[] { "->" }, StringSplitOptions.None);
                        foreach (string entry in ExpandRange(range)) {
                            ipsAndHosts.Add(entry);
                        }
                    }
                    else {
                        ipsAndHosts.Add(s);
                    }
                }
            }
            return ipsAndHosts.ToArray();
        }
        private IEnumerable<string> ExpandRange(string[] range) {
            foreach (string s in range) {
                if (string.IsNullOrEmpty(s)) throw new ArgumentNullException();
                if (!Regex.IsMatch(s, _regexIPv4)) throw new Exception("Malformatted range. Ranges only works for IPv4.");
            }

            int[] beginIPv4Parts = GetIPv4Parts(range[0]);
            int[] endIPv4Parts = GetIPv4Parts(range[1]);

            for (int i = 0; i != 3; i++) {
                if (beginIPv4Parts[i] != endIPv4Parts[i]) {
                    throw new Exception("The begin and the end of the range are not in the same subnet.");
                }
            }

            if (beginIPv4Parts[3] > endIPv4Parts[3]) {
                int[] temp = endIPv4Parts;
                endIPv4Parts = beginIPv4Parts;
                beginIPv4Parts = temp;
            }

            string firstPart = beginIPv4Parts[0] + "." + beginIPv4Parts[1] + "." + beginIPv4Parts[2] + ".";
            for (int lastPart = beginIPv4Parts[3]; lastPart <= endIPv4Parts[3]; lastPart++) {
                yield return firstPart + lastPart;
            }
        }

        private int[] GetIPv4Parts(string ipv4) {
            int[] parts = new int[4];
            int i = 0;
            foreach (string part in ipv4.Split('.')) {
                parts[i++] = int.Parse(part);
            }
            return parts;
        }

        private void btnClearLog_Click(object sender, EventArgs e) { rtxtLog.Text = ""; }

        private void btnSave_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var sw = new StreamWriter(saveFileDialog.FileName)) {
                    sw.WriteLine("IPs and Hosts: " + txtIPsHosts.Text.Trim().Replace('\n', ' ').Replace('\r', ' ').Replace('\t', ' '));
                    sw.Write("SSH command: " + txtSSHCommand.Text.Trim());
                    sw.Flush();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string ipsAndHostsPre = "IPs and Hosts: ";
                string sshCommandPre = "SSH command: ";

                using (var sr = new StreamReader(openFileDialog.FileName)) {
                    while (sr.Peek() != -1) {
                        string line = sr.ReadLine().Trim();
                        if (line.StartsWith(ipsAndHostsPre)) {
                            txtIPsHosts.Text = line.Substring(ipsAndHostsPre.Length);
                        }
                        else {
                            if (line.StartsWith(sshCommandPre)) {
                                txtSSHCommand.Text = line.Substring(sshCommandPre.Length);
                            }
                            else {
                                txtSSHCommand.Text += "\n" + line;
                            }
                        }

                    }
                }
            }
        }
    }
}
