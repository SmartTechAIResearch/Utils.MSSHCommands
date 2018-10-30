namespace msshcommands.Variables {
    partial class VariableSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariableSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.fctbTextToReplace = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.fctbValue = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pnlPlaceholder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fctbTextToReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to replace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(12, 326);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(204, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // fctbTextToReplace
            // 
            this.fctbTextToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbTextToReplace.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbTextToReplace.AutoScrollMinSize = new System.Drawing.Size(2, 16);
            this.fctbTextToReplace.BackBrush = null;
            this.fctbTextToReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbTextToReplace.CharHeight = 16;
            this.fctbTextToReplace.CharWidth = 8;
            this.fctbTextToReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbTextToReplace.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbTextToReplace.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.fctbTextToReplace.IsReplaceMode = false;
            this.fctbTextToReplace.Location = new System.Drawing.Point(15, 31);
            this.fctbTextToReplace.Margin = new System.Windows.Forms.Padding(2);
            this.fctbTextToReplace.Multiline = false;
            this.fctbTextToReplace.Name = "fctbTextToReplace";
            this.fctbTextToReplace.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbTextToReplace.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbTextToReplace.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbTextToReplace.ServiceColors")));
            this.fctbTextToReplace.ShowLineNumbers = false;
            this.fctbTextToReplace.ShowScrollBars = false;
            this.fctbTextToReplace.Size = new System.Drawing.Size(257, 20);
            this.fctbTextToReplace.TabIndex = 0;
            this.fctbTextToReplace.Zoom = 100;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Location = new System.Drawing.Point(222, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudStep
            // 
            this.nudStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStep.Location = new System.Drawing.Point(59, 96);
            this.nudStep.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudStep.Name = "nudStep";
            this.nudStep.Size = new System.Drawing.Size(213, 20);
            this.nudStep.TabIndex = 2;
            this.nudStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "at Step";
            // 
            // fctbValue
            // 
            this.fctbValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbValue.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbValue.AutoScrollMinSize = new System.Drawing.Size(2, 16);
            this.fctbValue.BackBrush = null;
            this.fctbValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbValue.CharHeight = 16;
            this.fctbValue.CharWidth = 8;
            this.fctbValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbValue.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbValue.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.fctbValue.IsReplaceMode = false;
            this.fctbValue.Location = new System.Drawing.Point(59, 71);
            this.fctbValue.Margin = new System.Windows.Forms.Padding(2);
            this.fctbValue.Multiline = false;
            this.fctbValue.Name = "fctbValue";
            this.fctbValue.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbValue.ReadOnly = true;
            this.fctbValue.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbValue.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbValue.ServiceColors")));
            this.fctbValue.ShowLineNumbers = false;
            this.fctbValue.ShowScrollBars = false;
            this.fctbValue.Size = new System.Drawing.Size(213, 20);
            this.fctbValue.TabIndex = 1;
            this.fctbValue.Zoom = 100;
            // 
            // pnlPlaceholder
            // 
            this.pnlPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlaceholder.Location = new System.Drawing.Point(0, 133);
            this.pnlPlaceholder.Name = "pnlPlaceholder";
            this.pnlPlaceholder.Size = new System.Drawing.Size(284, 187);
            this.pnlPlaceholder.TabIndex = 3;
            // 
            // VariableSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.pnlPlaceholder);
            this.Controls.Add(this.fctbValue);
            this.Controls.Add(this.nudStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.fctbTextToReplace);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "VariableSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.fctbTextToReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private FastColoredTextBoxNS.FastColoredTextBox fctbTextToReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudStep;
        private System.Windows.Forms.Label label4;
        private FastColoredTextBoxNS.FastColoredTextBox fctbValue;
        private System.Windows.Forms.Panel pnlPlaceholder;
    }
}