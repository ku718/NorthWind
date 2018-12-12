namespace MyWinformControl
{
    partial class myPic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myPic));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.picBoxMyImg = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkAuto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMyImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "꽃게꽃게.png");
            // 
            // picBoxMyImg
            // 
            this.picBoxMyImg.Location = new System.Drawing.Point(26, 27);
            this.picBoxMyImg.Name = "picBoxMyImg";
            this.picBoxMyImg.Size = new System.Drawing.Size(256, 256);
            this.picBoxMyImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMyImg.TabIndex = 0;
            this.picBoxMyImg.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(26, 372);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 45);
            this.trackBar.TabIndex = 0;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(321, 84);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(48, 16);
            this.chkAuto.TabIndex = 1;
            this.chkAuto.Text = "자동";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // myPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.picBoxMyImg);
            this.Name = "myPic";
            this.Text = "frmImageList";
            this.Load += new System.EventHandler(this.frmImageList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMyImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox picBoxMyImg;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAuto;
    }
}