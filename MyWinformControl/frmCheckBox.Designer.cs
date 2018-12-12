namespace MyWinformControl
{
    partial class frmCheckBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMovie = new System.Windows.Forms.CheckBox();
            this.chkGame = new System.Windows.Forms.CheckBox();
            this.chkCooking = new System.Windows.Forms.CheckBox();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMovie);
            this.groupBox1.Controls.Add(this.chkGame);
            this.groupBox1.Controls.Add(this.chkCooking);
            this.groupBox1.Controls.Add(this.chkReading);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "취미 선택";
            // 
            // chkMovie
            // 
            this.chkMovie.AutoSize = true;
            this.chkMovie.Location = new System.Drawing.Point(19, 226);
            this.chkMovie.Name = "chkMovie";
            this.chkMovie.Size = new System.Drawing.Size(72, 16);
            this.chkMovie.TabIndex = 3;
            this.chkMovie.Text = "영화보기";
            this.chkMovie.UseVisualStyleBackColor = true;
            // 
            // chkGame
            // 
            this.chkGame.AutoSize = true;
            this.chkGame.Location = new System.Drawing.Point(19, 166);
            this.chkGame.Name = "chkGame";
            this.chkGame.Size = new System.Drawing.Size(48, 16);
            this.chkGame.TabIndex = 2;
            this.chkGame.Text = "게임";
            this.chkGame.UseVisualStyleBackColor = true;
            // 
            // chkCooking
            // 
            this.chkCooking.AutoSize = true;
            this.chkCooking.Location = new System.Drawing.Point(19, 105);
            this.chkCooking.Name = "chkCooking";
            this.chkCooking.Size = new System.Drawing.Size(48, 16);
            this.chkCooking.TabIndex = 1;
            this.chkCooking.Text = "요리";
            this.chkCooking.UseVisualStyleBackColor = true;
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(19, 44);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(48, 16);
            this.chkReading.TabIndex = 0;
            this.chkReading.Text = "독서";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(43, 351);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(487, 281);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 43);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "결정";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCheckBox";
            this.Text = "frmCheckBox";
            this.Load += new System.EventHandler(this.frmCheckBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMovie;
        private System.Windows.Forms.CheckBox chkGame;
        private System.Windows.Forms.CheckBox chkCooking;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnShow;
    }
}