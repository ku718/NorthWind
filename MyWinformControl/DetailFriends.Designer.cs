namespace MyWinformControl
{
    partial class DetailFriends
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
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxImage
            // 
            this.picboxImage.Location = new System.Drawing.Point(12, 12);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(378, 426);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 0;
            this.picboxImage.TabStop = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(437, 12);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(0, 12);
            this.lblNo.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(437, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 12);
            this.lblName.TabIndex = 2;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(437, 149);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(0, 12);
            this.lblMobile.TabIndex = 3;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(437, 220);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(0, 12);
            this.lblAddr.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(578, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DetailFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.picboxImage);
            this.Name = "DetailFriends";
            this.Text = "DetailFriends";
            this.Load += new System.EventHandler(this.DetailFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClose;
    }
}