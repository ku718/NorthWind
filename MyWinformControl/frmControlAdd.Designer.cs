namespace MyWinformControl
{
    partial class frmControlAdd
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
            this.btnButton = new System.Windows.Forms.Button();
            this.chkButton = new System.Windows.Forms.CheckBox();
            this.chkButton2 = new System.Windows.Forms.CheckBox();
            this.btnButton2 = new System.Windows.Forms.Button();
            this.lblControlList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(254, 47);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "button1";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // chkButton
            // 
            this.chkButton.AutoSize = true;
            this.chkButton.Location = new System.Drawing.Point(85, 47);
            this.chkButton.Name = "chkButton";
            this.chkButton.Size = new System.Drawing.Size(97, 16);
            this.chkButton.TabIndex = 1;
            this.chkButton.Text = "visible on/off";
            this.chkButton.UseVisualStyleBackColor = true;
            this.chkButton.CheckedChanged += new System.EventHandler(this.chkButton_CheckedChanged);
            // 
            // chkButton2
            // 
            this.chkButton2.AutoSize = true;
            this.chkButton2.Location = new System.Drawing.Point(85, 148);
            this.chkButton2.Name = "chkButton2";
            this.chkButton2.Size = new System.Drawing.Size(100, 16);
            this.chkButton2.TabIndex = 3;
            this.chkButton2.Text = "Enable on/off";
            this.chkButton2.UseVisualStyleBackColor = true;
            this.chkButton2.CheckedChanged += new System.EventHandler(this.chkButton2_CheckedChanged);
            // 
            // btnButton2
            // 
            this.btnButton2.Location = new System.Drawing.Point(254, 148);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Size = new System.Drawing.Size(75, 23);
            this.btnButton2.TabIndex = 2;
            this.btnButton2.Text = "button1";
            this.btnButton2.UseVisualStyleBackColor = true;
            // 
            // lblControlList
            // 
            this.lblControlList.AutoSize = true;
            this.lblControlList.Location = new System.Drawing.Point(32, 286);
            this.lblControlList.Name = "lblControlList";
            this.lblControlList.Size = new System.Drawing.Size(38, 12);
            this.lblControlList.TabIndex = 4;
            this.lblControlList.Text = "label1";
            // 
            // frmControlAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblControlList);
            this.Controls.Add(this.chkButton2);
            this.Controls.Add(this.btnButton2);
            this.Controls.Add(this.chkButton);
            this.Controls.Add(this.btnButton);
            this.Name = "frmControlAdd";
            this.Text = "frmControlAdd";
            this.Load += new System.EventHandler(this.frmControlAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.CheckBox chkButton;
        private System.Windows.Forms.CheckBox chkButton2;
        private System.Windows.Forms.Button btnButton2;
        private System.Windows.Forms.Label lblControlList;
    }
}