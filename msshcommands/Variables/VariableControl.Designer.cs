namespace msshcommands.Variables {
    partial class VariableControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariableControl));
            this.chkUse = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.fctbTextToReplace = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fctbTextToReplace)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUse
            // 
            this.chkUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUse.AutoSize = true;
            this.chkUse.Location = new System.Drawing.Point(6, 28);
            this.chkUse.Name = "chkUse";
            this.chkUse.Size = new System.Drawing.Size(45, 17);
            this.chkUse.TabIndex = 0;
            this.chkUse.Text = "Use";
            this.chkUse.UseVisualStyleBackColor = true;
            this.chkUse.CheckedChanged += new System.EventHandler(this.chkUse_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.Location = new System.Drawing.Point(442, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(26, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(472, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.fctbTextToReplace.AutoScrollMinSize = new System.Drawing.Size(122, 16);
            this.fctbTextToReplace.BackBrush = null;
            this.fctbTextToReplace.CharHeight = 16;
            this.fctbTextToReplace.CharWidth = 8;
            this.fctbTextToReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbTextToReplace.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbTextToReplace.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.fctbTextToReplace.IsReplaceMode = false;
            this.fctbTextToReplace.Location = new System.Drawing.Point(6, 3);
            this.fctbTextToReplace.Margin = new System.Windows.Forms.Padding(2);
            this.fctbTextToReplace.Multiline = false;
            this.fctbTextToReplace.Name = "fctbTextToReplace";
            this.fctbTextToReplace.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbTextToReplace.ReadOnly = true;
            this.fctbTextToReplace.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbTextToReplace.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbTextToReplace.ServiceColors")));
            this.fctbTextToReplace.ShowLineNumbers = false;
            this.fctbTextToReplace.ShowScrollBars = false;
            this.fctbTextToReplace.Size = new System.Drawing.Size(491, 20);
            this.fctbTextToReplace.TabIndex = 5;
            this.fctbTextToReplace.Text = "Text to replace";
            this.fctbTextToReplace.Zoom = 100;
            // 
            // VariableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fctbTextToReplace);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chkUse);
            this.Name = "VariableControl";
            this.Size = new System.Drawing.Size(500, 50);
            ((System.ComponentModel.ISupportInitialize)(this.fctbTextToReplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private FastColoredTextBoxNS.FastColoredTextBox fctbTextToReplace;
    }
}
