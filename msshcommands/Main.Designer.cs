namespace msshcommands {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSSHCommand = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkAutomation = new System.Windows.Forms.CheckBox();
            this.chkAutoClearLog = new System.Windows.Forms.CheckBox();
            this.txtSSHCommand = new msshcommands.CueTextBox();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.chkKeepAlive = new System.Windows.Forms.CheckBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.txtPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIPsHosts = new System.Windows.Forms.TextBox();
            this.btnAutomation = new System.Windows.Forms.Button();
            this.pnlAutomation = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.pnlAutomation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(716, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.AutoSize = true;
            this.btnLoad.Location = new System.Drawing.Point(797, 526);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSSHCommand
            // 
            this.btnSSHCommand.AutoSize = true;
            this.btnSSHCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSHCommand.Location = new System.Drawing.Point(143, 275);
            this.btnSSHCommand.Name = "btnSSHCommand";
            this.btnSSHCommand.Size = new System.Drawing.Size(103, 23);
            this.btnSSHCommand.TabIndex = 8;
            this.btnSSHCommand.Text = "SSH command:";
            this.btnSSHCommand.UseVisualStyleBackColor = true;
            this.btnSSHCommand.Click += new System.EventHandler(this.btnSSHCommand_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(97, 180);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.Location = new System.Drawing.Point(332, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(540, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "or Private key file";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(797, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Text files|*.txt|All files|*.*\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "with Passphrase";
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassphrase.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassphrase.Location = new System.Drawing.Point(332, 229);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.PasswordChar = '*';
            this.txtPassphrase.Size = new System.Drawing.Size(459, 20);
            this.txtPassphrase.TabIndex = 6;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"Text files|*.txt|All files|*.*\"";
            this.saveFileDialog.Title = "All but credentials is saved.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Log:";
            // 
            // rtxtLog
            // 
            this.rtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtLog.BackColor = System.Drawing.Color.White;
            this.rtxtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLog.Location = new System.Drawing.Point(0, 23);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(860, 85);
            this.rtxtLog.TabIndex = 0;
            this.rtxtLog.Text = "";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLog.AutoSize = true;
            this.btnClearLog.Location = new System.Drawing.Point(12, 526);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Timeout";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "seconds";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 301);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.txtSSHCommand);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.rtxtLog);
            this.splitContainer1.Size = new System.Drawing.Size(860, 219);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 11;
            // 
            // chkAutomation
            // 
            this.chkAutomation.AutoSize = true;
            this.chkAutomation.Checked = global::msshcommands.Properties.Settings.Default.Automation;
            this.chkAutomation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::msshcommands.Properties.Settings.Default, "Automation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutomation.Location = new System.Drawing.Point(3, 8);
            this.chkAutomation.Name = "chkAutomation";
            this.chkAutomation.Size = new System.Drawing.Size(89, 17);
            this.chkAutomation.TabIndex = 0;
            this.chkAutomation.Text = "Automation";
            this.chkAutomation.UseVisualStyleBackColor = true;
            // 
            // chkAutoClearLog
            // 
            this.chkAutoClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoClearLog.AutoSize = true;
            this.chkAutoClearLog.Checked = global::msshcommands.Properties.Settings.Default.AutoClearLog;
            this.chkAutoClearLog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::msshcommands.Properties.Settings.Default, "AutoClearLog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoClearLog.Location = new System.Drawing.Point(92, 530);
            this.chkAutoClearLog.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoClearLog.Name = "chkAutoClearLog";
            this.chkAutoClearLog.Size = new System.Drawing.Size(74, 17);
            this.chkAutoClearLog.TabIndex = 2;
            this.chkAutoClearLog.Text = "Auto clear";
            this.toolTip.SetToolTip(this.chkAutoClearLog, "Check to clear on each SSH comand");
            this.chkAutoClearLog.UseVisualStyleBackColor = true;
            // 
            // txtSSHCommand
            // 
            this.txtSSHCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSSHCommand.Cue = " send/cancel: ctrl+enter - history: ctrl+up, ctrl+down, ctrl+r";
            this.txtSSHCommand.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::msshcommands.Properties.Settings.Default, "SSHCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSSHCommand.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSHCommand.Location = new System.Drawing.Point(0, 0);
            this.txtSSHCommand.Multiline = true;
            this.txtSSHCommand.Name = "txtSSHCommand";
            this.txtSSHCommand.Size = new System.Drawing.Size(860, 104);
            this.txtSSHCommand.TabIndex = 0;
            this.txtSSHCommand.Text = global::msshcommands.Properties.Settings.Default.SSHCommand;
            this.txtSSHCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtSSHCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSSHCommand_KeyUp);
            // 
            // nudTimeout
            // 
            this.nudTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::msshcommands.Properties.Settings.Default, "Timeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudTimeout.Location = new System.Drawing.Point(626, 278);
            this.nudTimeout.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(50, 20);
            this.nudTimeout.TabIndex = 9;
            this.nudTimeout.Value = global::msshcommands.Properties.Settings.Default.Timeout;
            // 
            // chkKeepAlive
            // 
            this.chkKeepAlive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkKeepAlive.AutoSize = true;
            this.chkKeepAlive.Checked = global::msshcommands.Properties.Settings.Default.KeepAlive;
            this.chkKeepAlive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepAlive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::msshcommands.Properties.Settings.Default, "KeepAlive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkKeepAlive.Location = new System.Drawing.Point(735, 279);
            this.chkKeepAlive.Name = "chkKeepAlive";
            this.chkKeepAlive.Size = new System.Drawing.Size(137, 17);
            this.chkKeepAlive.TabIndex = 10;
            this.chkKeepAlive.Text = "Keep connections alive";
            this.chkKeepAlive.UseVisualStyleBackColor = true;
            this.chkKeepAlive.CheckedChanged += new System.EventHandler(this.chkKeepAlive_CheckedChanged);
            // 
            // nudPort
            // 
            this.nudPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::msshcommands.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudPort.Location = new System.Drawing.Point(41, 177);
            this.nudPort.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(50, 20);
            this.nudPort.TabIndex = 1;
            this.nudPort.Value = global::msshcommands.Properties.Settings.Default.Port;
            // 
            // txtPrivateKeyFile
            // 
            this.txtPrivateKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrivateKeyFile.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrivateKeyFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::msshcommands.Properties.Settings.Default, "PrivateKeyFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrivateKeyFile.Location = new System.Drawing.Point(332, 203);
            this.txtPrivateKeyFile.Name = "txtPrivateKeyFile";
            this.txtPrivateKeyFile.Size = new System.Drawing.Size(459, 20);
            this.txtPrivateKeyFile.TabIndex = 4;
            this.txtPrivateKeyFile.Text = global::msshcommands.Properties.Settings.Default.PrivateKeyFile;
            // 
            // txtUser
            // 
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::msshcommands.Properties.Settings.Default, "User", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUser.Location = new System.Drawing.Point(132, 177);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = global::msshcommands.Properties.Settings.Default.User;
            // 
            // txtIPsHosts
            // 
            this.txtIPsHosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPsHosts.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::msshcommands.Properties.Settings.Default, "IPsHosts", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtIPsHosts.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPsHosts.Location = new System.Drawing.Point(12, 81);
            this.txtIPsHosts.Multiline = true;
            this.txtIPsHosts.Name = "txtIPsHosts";
            this.txtIPsHosts.Size = new System.Drawing.Size(860, 90);
            this.txtIPsHosts.TabIndex = 0;
            this.txtIPsHosts.Text = global::msshcommands.Properties.Settings.Default.IPsHosts;
            this.txtIPsHosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtIPsHosts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIPsHosts_KeyUp);
            // 
            // btnAutomation
            // 
            this.btnAutomation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutomation.AutoSize = true;
            this.btnAutomation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAutomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomation.Location = new System.Drawing.Point(91, 3);
            this.btnAutomation.Name = "btnAutomation";
            this.btnAutomation.Size = new System.Drawing.Size(29, 23);
            this.btnAutomation.TabIndex = 1;
            this.btnAutomation.Text = "...";
            this.btnAutomation.UseVisualStyleBackColor = true;
            this.btnAutomation.Click += new System.EventHandler(this.btnAutomation_Click);
            // 
            // pnlAutomation
            // 
            this.pnlAutomation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAutomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAutomation.Controls.Add(this.btnAutomation);
            this.pnlAutomation.Controls.Add(this.chkAutomation);
            this.pnlAutomation.Location = new System.Drawing.Point(12, 271);
            this.pnlAutomation.Name = "pnlAutomation";
            this.pnlAutomation.Size = new System.Drawing.Size(125, 31);
            this.pnlAutomation.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlAutomation);
            this.Controls.Add(this.chkAutoClearLog);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudTimeout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkKeepAlive);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassphrase);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrivateKeyFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSSHCommand);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIPsHosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msshcommands";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.pnlAutomation.ResumeLayout(false);
            this.pnlAutomation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPsHosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSSHCommand;
        private CueTextBox txtSSHCommand;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrivateKeyFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.CheckBox chkKeepAlive;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkAutoClearLog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox chkAutomation;
        private System.Windows.Forms.Button btnAutomation;
        private System.Windows.Forms.Panel pnlAutomation;
    }
}

