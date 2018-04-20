/*
    Dieter Vandroemme
    2018
    MIT License

    A small tool to send a ssh command to multiple devices at the same time.

 */

using Renci.SshNet;
using System;
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

            Properties.Settings.Default.Save();
        }

        private void Init() {
            _synchronizationContext = SynchronizationContext.Current;
        }

        private void btnSSHCommand_Click(object sender, EventArgs e) { SendSSHCommand(); }

        private void SendSSHCommand() {
            int port = Convert.ToInt32(nudPort.Value);
            string user = txtUser.Text.Trim();
            string password = txtPassword.Text;

            PrivateKeyFile pkf = null;

            string privateKeyFile = txtPrivateKeyFile.Text.Trim();
            string passphrase = txtPassphrase.Text;

            string command = txtSSHCommand.Text.Replace("\r\n", "\n").Trim();

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

            if (txtIPsHosts.Text.Trim().Length == 0 || user.Length == 0 || command.Length == 0) {
                Log("Cannot send a command if not all fields are filled in.");
                return;
            }

            Parallel.ForEach(GetIPsAndHosts(), (ipOrHost) => {
                try {
                    using (var client = pkf == null ? new SshClient(ipOrHost, port, user, password) : new SshClient(ipOrHost, port, user, pkf)) {
                        client.Connect();
                        client.RunCommand(command);
                    }
                }
                catch (Exception ex) {
                    _synchronizationContext.Send((state) => {
                        Log(ipOrHost + " - " + ex.ToString().Replace("\n", " ").Replace("\r", " ").Replace("\t", " "));
                    }, null);
                }
            });
            Log("DONE.");
        }

        private void Log(string s) { txtLog.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") + " - " + s + Environment.NewLine + txtLog.Text; }
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
