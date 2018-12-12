namespace MyWinformControl
{
    partial class frmDataTransferEx2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransfer = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "전달할 메세지";
            // 
            // txtTransfer
            // 
            this.txtTransfer.Location = new System.Drawing.Point(159, 76);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(360, 21);
            this.txtTransfer.TabIndex = 1;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(525, 74);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(84, 23);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "데이터 전달";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(61, 28);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(48, 16);
            this.chkAgree.TabIndex = 3;
            this.chkAgree.Text = "동의";
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.CheckedChanged += new System.EventHandler(this.chkAgree_CheckedChanged);
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(61, 199);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(0, 12);
            this.lblParent.TabIndex = 4;
            // 
            // frmDataTransferEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 367);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.chkAgree);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransfer);
            this.Controls.Add(this.label1);
            this.Name = "frmDataTransferEx2";
            this.Text = "frmDataTransferEx2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransfer;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Label lblParent;
    }
}