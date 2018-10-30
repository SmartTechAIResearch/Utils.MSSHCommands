namespace msshcommands
{
    partial class Automation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.flpVars = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearVars = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudIssue = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Define lists and ranges, use their name, e.g. $var, in the SSH command\r\n- Set h" +
    "ow many times the command must be issued\r\n- Note: variables values always reset " +
    "to start / overflow to start if needed";
            // 
            // btnAddList
            // 
            this.btnAddList.AutoSize = true;
            this.btnAddList.Location = new System.Drawing.Point(15, 103);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 23);
            this.btnAddList.TabIndex = 0;
            this.btnAddList.Text = "Add list...";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.AutoSize = true;
            this.btnAddRange.Location = new System.Drawing.Point(96, 103);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(75, 23);
            this.btnAddRange.TabIndex = 1;
            this.btnAddRange.Text = "Add range...";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // flpVars
            // 
            this.flpVars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpVars.BackColor = System.Drawing.SystemColors.Control;
            this.flpVars.Location = new System.Drawing.Point(15, 132);
            this.flpVars.Name = "flpVars";
            this.flpVars.Padding = new System.Windows.Forms.Padding(3);
            this.flpVars.Size = new System.Drawing.Size(557, 288);
            this.flpVars.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Issue command";
            // 
            // btnClearVars
            // 
            this.btnClearVars.AutoSize = true;
            this.btnClearVars.Location = new System.Drawing.Point(177, 103);
            this.btnClearVars.Name = "btnClearVars";
            this.btnClearVars.Size = new System.Drawing.Size(86, 23);
            this.btnClearVars.TabIndex = 2;
            this.btnClearVars.Text = "Clear variables";
            this.btnClearVars.UseVisualStyleBackColor = true;
            this.btnClearVars.Click += new System.EventHandler(this.btnClearVars_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "times";
            // 
            // nudIssue
            // 
            this.nudIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudIssue.Location = new System.Drawing.Point(121, 429);
            this.nudIssue.Name = "nudIssue";
            this.nudIssue.Size = new System.Drawing.Size(120, 20);
            this.nudIssue.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(486, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Automation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.nudIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearVars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpVars);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Automation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Use variables to automate commands";
            ((System.ComponentModel.ISupportInitialize)(this.nudIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnAddRange;
        private System.Windows.Forms.FlowLayoutPanel flpVars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearVars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudIssue;
        private System.Windows.Forms.Button btnClose;
    }
}