namespace MyWinformControl
{
    partial class frmRadioButton
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
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoSoccer = new System.Windows.Forms.RadioButton();
            this.rdoPlay = new System.Windows.Forms.RadioButton();
            this.rdoClimb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(83, 102);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(47, 16);
            this.rdomale.TabIndex = 0;
            this.rdomale.Text = "남자";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Checked = true;
            this.rdoFemale.Location = new System.Drawing.Point(83, 160);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(47, 16);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "여자";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoSoccer
            // 
            this.rdoSoccer.AutoSize = true;
            this.rdoSoccer.Location = new System.Drawing.Point(41, 26);
            this.rdoSoccer.Name = "rdoSoccer";
            this.rdoSoccer.Size = new System.Drawing.Size(83, 16);
            this.rdoSoccer.TabIndex = 2;
            this.rdoSoccer.Text = "축구동아리";
            this.rdoSoccer.UseVisualStyleBackColor = true;
            // 
            // rdoPlay
            // 
            this.rdoPlay.AutoSize = true;
            this.rdoPlay.Checked = true;
            this.rdoPlay.Location = new System.Drawing.Point(41, 84);
            this.rdoPlay.Name = "rdoPlay";
            this.rdoPlay.Size = new System.Drawing.Size(71, 16);
            this.rdoPlay.TabIndex = 3;
            this.rdoPlay.TabStop = true;
            this.rdoPlay.Text = "음주가무";
            this.rdoPlay.UseVisualStyleBackColor = true;
            // 
            // rdoClimb
            // 
            this.rdoClimb.AutoSize = true;
            this.rdoClimb.Location = new System.Drawing.Point(41, 144);
            this.rdoClimb.Name = "rdoClimb";
            this.rdoClimb.Size = new System.Drawing.Size(87, 16);
            this.rdoClimb.TabIndex = 4;
            this.rdoClimb.Text = "등산 동아리";
            this.rdoClimb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(59, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별 선택";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoClimb);
            this.groupBox2.Controls.Add(this.rdoPlay);
            this.groupBox2.Controls.Add(this.rdoSoccer);
            this.groupBox2.Location = new System.Drawing.Point(427, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "동아리 선택";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(640, 303);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(127, 42);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "결정 !";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(80, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 8;
            // 
            // frmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmRadioButton";
            this.Text = "frmRadioButton";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoSoccer;
        private System.Windows.Forms.RadioButton rdoPlay;
        private System.Windows.Forms.RadioButton rdoClimb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblResult;
    }
}