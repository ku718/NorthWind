namespace MyWinformControl
{
    partial class frmComboBoxEx
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
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboJob
            // 
            this.cboJob.FormattingEnabled = true;
            this.cboJob.Items.AddRange(new object[] {
            "회사원",
            "공무원",
            "프로그래머",
            "학생",
            "백수"});
            this.cboJob.Location = new System.Drawing.Point(63, 58);
            this.cboJob.Name = "cboJob";
            this.cboJob.Size = new System.Drawing.Size(121, 20);
            this.cboJob.TabIndex = 0;
            this.cboJob.SelectedIndexChanged += new System.EventHandler(this.cboJob_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "당신의 직업은?";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(65, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 2;
            // 
            // frmComboBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboJob);
            this.Name = "frmComboBoxEx";
            this.Text = "frmComboBoxEx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}