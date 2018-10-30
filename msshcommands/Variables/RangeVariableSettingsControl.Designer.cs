namespace msshcommands.Variables {
    partial class RangeVariableSettingsControl {
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudInclusiveFrom = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfSteps = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStepsize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInclusiveFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inclusive from";
            // 
            // nudInclusiveFrom
            // 
            this.nudInclusiveFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInclusiveFrom.Location = new System.Drawing.Point(102, 3);
            this.nudInclusiveFrom.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudInclusiveFrom.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudInclusiveFrom.Name = "nudInclusiveFrom";
            this.nudInclusiveFrom.Size = new System.Drawing.Size(151, 20);
            this.nudInclusiveFrom.TabIndex = 1;
            // 
            // nudNumberOfSteps
            // 
            this.nudNumberOfSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumberOfSteps.Location = new System.Drawing.Point(102, 29);
            this.nudNumberOfSteps.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudNumberOfSteps.Name = "nudNumberOfSteps";
            this.nudNumberOfSteps.Size = new System.Drawing.Size(151, 20);
            this.nudNumberOfSteps.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of steps";
            // 
            // nudStepsize
            // 
            this.nudStepsize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStepsize.Location = new System.Drawing.Point(102, 55);
            this.nudStepsize.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudStepsize.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudStepsize.Name = "nudStepsize";
            this.nudStepsize.Size = new System.Drawing.Size(151, 20);
            this.nudStepsize.TabIndex = 3;
            this.nudStepsize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "with Stepsize";
            // 
            // nudDecimalPlaces
            // 
            this.nudDecimalPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDecimalPlaces.Location = new System.Drawing.Point(102, 99);
            this.nudDecimalPlaces.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudDecimalPlaces.Name = "nudDecimalPlaces";
            this.nudDecimalPlaces.Size = new System.Drawing.Size(151, 20);
            this.nudDecimalPlaces.TabIndex = 4;
            this.nudDecimalPlaces.ValueChanged += new System.EventHandler(this.nudDecimalPlaces_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Decimal places";
            // 
            // RangeVariableSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudDecimalPlaces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudStepsize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudNumberOfSteps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudInclusiveFrom);
            this.Controls.Add(this.label2);
            this.Name = "RangeVariableSettings";
            this.Size = new System.Drawing.Size(265, 123);
            ((System.ComponentModel.ISupportInitialize)(this.nudInclusiveFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudInclusiveFrom;
        private System.Windows.Forms.NumericUpDown nudNumberOfSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStepsize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDecimalPlaces;
        private System.Windows.Forms.Label label5;
    }
}