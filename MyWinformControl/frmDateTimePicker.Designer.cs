namespace MyWinformControl
{
    partial class frmDateTimePicker
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
            this.cal1 = new System.Windows.Forms.DateTimePicker();
            this.cal2 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cal1
            // 
            this.cal1.Location = new System.Drawing.Point(43, 53);
            this.cal1.Name = "cal1";
            this.cal1.Size = new System.Drawing.Size(200, 21);
            this.cal1.TabIndex = 0;
            this.cal1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cal2
            // 
            this.cal2.Location = new System.Drawing.Point(43, 111);
            this.cal2.Name = "cal2";
            this.cal2.TabIndex = 1;
            this.cal2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // frmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cal2);
            this.Controls.Add(this.cal1);
            this.Name = "frmDateTimePicker";
            this.Text = "frmDateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cal1;
        private System.Windows.Forms.MonthCalendar cal2;
        private System.Windows.Forms.Label label1;
    }
}