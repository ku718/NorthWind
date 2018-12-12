namespace MyWinformControl
{
    partial class frmListViewEx2
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
            this.listDir = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.changeDir = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // listDir
            // 
            this.listDir.Location = new System.Drawing.Point(283, 13);
            this.listDir.Name = "listDir";
            this.listDir.Size = new System.Drawing.Size(671, 369);
            this.listDir.TabIndex = 0;
            this.listDir.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // changeDir
            // 
            this.changeDir.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.changeDir.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.changeDir.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmListViewEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listDir);
            this.Name = "frmListViewEx2";
            this.Text = "frmListViewEx2";
            this.Load += new System.EventHandler(this.frmListViewEx2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listDir;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectorySearcher changeDir;
    }
}