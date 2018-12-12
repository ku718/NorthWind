namespace MyWinformControl
{
    partial class frmListBoxQuiz
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
            this.lblMainSelect = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblSubSelect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMainSelect
            // 
            this.lblMainSelect.FormattingEnabled = true;
            this.lblMainSelect.ItemHeight = 12;
            this.lblMainSelect.Location = new System.Drawing.Point(57, 35);
            this.lblMainSelect.Name = "lblMainSelect";
            this.lblMainSelect.Size = new System.Drawing.Size(120, 88);
            this.lblMainSelect.TabIndex = 0;
            this.lblMainSelect.SelectedIndexChanged += new System.EventHandler(this.lblMainSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "지역선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "세부지역선택";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutput.Location = new System.Drawing.Point(57, 237);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 4;
            // 
            // lblSubSelect
            // 
            this.lblSubSelect.FormattingEnabled = true;
            this.lblSubSelect.ItemHeight = 12;
            this.lblSubSelect.Location = new System.Drawing.Point(378, 35);
            this.lblSubSelect.Name = "lblSubSelect";
            this.lblSubSelect.Size = new System.Drawing.Size(120, 88);
            this.lblSubSelect.TabIndex = 1;
            // 
            // frmListBoxQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubSelect);
            this.Controls.Add(this.lblMainSelect);
            this.Name = "frmListBoxQuiz";
            this.Text = "frmListBoxQuiz";
            this.Load += new System.EventHandler(this.frmListBoxQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblMainSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox lblSubSelect;
    }
}