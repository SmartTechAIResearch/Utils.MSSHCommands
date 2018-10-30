namespace msshcommands.Variables {
    partial class ListVariableSettingsControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListVariableSettingsControl));
            this.fctbList = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fctbList)).BeginInit();
            this.SuspendLayout();
            // 
            // fctbList
            // 
            this.fctbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbList.AutoCompleteBracketsList = new char[] {
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
            this.fctbList.AutoScrollMinSize = new System.Drawing.Size(59, 17);
            this.fctbList.BackBrush = null;
            this.fctbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctbList.CharHeight = 17;
            this.fctbList.CharWidth = 8;
            this.fctbList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbList.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbList.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.fctbList.IsReplaceMode = false;
            this.fctbList.Location = new System.Drawing.Point(15, 22);
            this.fctbList.Name = "fctbList";
            this.fctbList.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbList.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbList.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbList.ServiceColors")));
            this.fctbList.Size = new System.Drawing.Size(238, 336);
            this.fctbList.TabIndex = 1;
            this.fctbList.Text = "item";
            this.fctbList.Zoom = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "One item per line";
            // 
            // ListVariableSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fctbList);
            this.Name = "ListVariableSettingsControl";
            this.Size = new System.Drawing.Size(265, 361);
            ((System.ComponentModel.ISupportInitialize)(this.fctbList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FastColoredTextBoxNS.FastColoredTextBox fctbList;
        private System.Windows.Forms.Label label2;
    }
}