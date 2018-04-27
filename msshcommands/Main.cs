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

        private LinkedList<string> _commandHistory = new LinkedList<string>();
        private LinkedListNode<string> _currentCommandHistoryNode;
        private bool _controlPressed;

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private int _commandsSend;

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
            DisposeSshClients();

            Properties.Settings.Default.Save();
        }

        private void Init() { _synchronizationContext = SynchronizationContext.Current; }

        private void btnSSHCommand_Click(object sender, EventArgs e) {
            if (btnSSHCommand.Text == "SSH command:") {
                SendSSHCommand();
            }
            else {
                CancelSSHCommand();
            }
        }

        private void SendSSHCommand() {
            string command = txtSSHCommand.Text.Replace("\r\n", "\n").Trim();
            if (command.Length == 0) return;

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

            if (_commandHistory.Count == 0 || txtSSHCommand.Text != _commandHistory.Last.Value) {
                _currentCommandHistoryNode = _commandHistory.AddLast(command);
            }

            if (_commandHistory.Count > 200) _commandHistory.RemoveFirst();

            int timeout = Convert.ToInt32(nudTimeout.Value);
            bool keepAlive = chkKeepAlive.Checked;

            if (txtIPsHosts.Text.Trim().Length == 0 || user.Length == 0 || (password.Length == 0 && pkf == null) || command.Length == 0) {
                Log("Cannot send a command if not all fields are filled in.");
            }
            else {
                btnSSHCommand.Text = "Cancel";
                nudTimeout.Enabled = chkKeepAlive.Enabled = false;

                string[] ipsAndHosts = GetIPsAndHosts();
                _commandsSend = 0;
                ThreadPool.SetMaxThreads(int.MaxValue, int.MaxValue);

                foreach (string ioh in ipsAndHosts) {
                    ThreadPool.QueueUserWorkItem((state) => {
                        string ipOrHost = state.ToString();

                        try {
                            SshClient client;
                            _clients.TryGetValue(ipOrHost, out client);

                            if (client == null) {
                                client = pkf == null ? new SshClient(ipOrHost, port, user, password) : new SshClient(ipOrHost, port, user, pkf);
                            }

                            if (!_cancellationTokenSource.Token.IsCancellationRequested) {
                                if (!client.IsConnected) {
                                    _synchronizationContext.Send((state2) => { Log(state2.ToString()); }, ipOrHost + "\nConnecting...");
                                    client.Connect();
                                }
                                if (!client.IsConnected) throw new Exception("Failed to connect");
                            }

                            if (!_cancellationTokenSource.Token.IsCancellationRequested) {
                                SshCommand sshc = client.CreateCommand(command);
                                sshc.CommandTimeout = TimeSpan.FromSeconds(timeout);

                                string result = sshc.Execute();


                                if (string.IsNullOrWhiteSpace(result)) result = "OK";

                                _synchronizationContext.Send((state2) => { Log(state2.ToString()); }, ipOrHost + "\n" + result);

                                if (keepAlive) _clients.TryAdd(ipOrHost, client); else client.Dispose();
                            }
                        }
                        catch (Exception ex) {
                            if (!_cancellationTokenSource.IsCancellationRequested) {
                                _synchronizationContext.Post((state2) => {
                                    Log(state2.ToString());
                                }, ipOrHost + " - " + ex.Message.Replace("\n", " ").Replace("\r", " ").Replace("\t", " "));
                            }
                        }

                        if (Interlocked.Increment(ref _commandsSend) >= ipsAndHosts.Length) {
                            _synchronizationContext.Post((state2) => {
                                btnSSHCommand.Enabled = true;
                                btnSSHCommand.Text = "SSH command:";
                                nudTimeout.Enabled = chkKeepAlive.Enabled = true;
                                _cancellationTokenSource = new CancellationTokenSource();
                            }, null);
                        }

                    }, ioh);

                }
            }
        }

        private void CancelSSHCommand() {
            if (MessageBox.Show("Cancelling will close all SSH connections.\nAre you sure that you want to to this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                btnSSHCommand.Enabled = false;
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

        private void txtSSHCommand_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ControlKey) _controlPressed = true;
        }

        private void txtSSHCommand_KeyUp(object sender, KeyEventArgs e) {
            if (_currentCommandHistoryNode == null) _currentCommandHistoryNode = _commandHistory.Last;
            if (e.KeyCode == Keys.ControlKey) {
                _controlPressed = false;
            }
            else {
                if (_controlPressed && _currentCommandHistoryNode != null) {
                    if (e.KeyCode == Keys.Up && _currentCommandHistoryNode.Previous != null) {
                        string command = txtSSHCommand.Text.Replace("\r\n", "\n").Trim();
                        if (command.Length == 0) return;
                        if (_currentCommandHistoryNode == _commandHistory.First) return;

                        _currentCommandHistoryNode = _currentCommandHistoryNode.Previous;
                        txtSSHCommand.Text = _currentCommandHistoryNode.Value;
                    }
                    else if (e.KeyCode == Keys.Down && _currentCommandHistoryNode.Next != null) {
                        string command = txtSSHCommand.Text.Replace("\r\n", "\n").Trim();
                        if (command.Length == 0) return;
                        if (_currentCommandHistoryNode == _commandHistory.Last) return;

                        _currentCommandHistoryNode = _currentCommandHistoryNode.Next;
                        txtSSHCommand.Text = _currentCommandHistoryNode.Value;
                    }
                }
            }
        }
        private void Log(string s) { rtxtLog.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + " - " + s.TrimEnd() + "\n\n" + rtxtLog.Text; }
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
