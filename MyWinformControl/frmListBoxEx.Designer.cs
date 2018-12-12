namespace MyWinformControl
{
    partial class frmListBoxEx
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
            this.lstHobby = new System.Windows.Forms.ListBox();
            this.lblReuslt = new System.Windows.Forms.Label();
            this.lstBloodType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHobby
            // 
            this.lstHobby.FormattingEnabled = true;
            this.lstHobby.ItemHeight = 12;
            this.lstHobby.Items.AddRange(new object[] {
            "독서",
            "음주가무",
            "게임",
            "낮잠",
            "영화보기",
            "음악감상"});
            this.lstHobby.Location = new System.Drawing.Point(33, 38);
            this.lstHobby.Name = "lstHobby";
            this.lstHobby.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstHobby.Size = new System.Drawing.Size(168, 208);
            this.lstHobby.TabIndex = 0;
            this.lstHobby.SelectedIndexChanged += new System.EventHandler(this.lstHobby_SelectedIndexChanged);
            // 
            // lblReuslt
            // 
            this.lblReuslt.AutoSize = true;
            this.lblReuslt.Location = new System.Drawing.Point(33, 303);
            this.lblReuslt.Name = "lblReuslt";
            this.lblReuslt.Size = new System.Drawing.Size(0, 12);
            this.lblReuslt.TabIndex = 1;
            // 
            // lstBloodType
            // 
            this.lstBloodType.FormattingEnabled = true;
            this.lstBloodType.ItemHeight = 12;
            this.lstBloodType.Location = new System.Drawing.Point(486, 38);
            this.lstBloodType.Name = "lstBloodType";
            this.lstBloodType.Size = new System.Drawing.Size(168, 208);
            this.lstBloodType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "취미를 선택하세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "혈액형을 선택하세요";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(579, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "제출";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmListBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBloodType);
            this.Controls.Add(this.lblReuslt);
            this.Controls.Add(this.lstHobby);
            this.Name = "frmListBoxEx";
            this.Text = "frmListBoxEx";
            this.Load += new System.EventHandler(this.frmListBoxEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHobby;
        private System.Windows.Forms.Label lblReuslt;
        private System.Windows.Forms.ListBox lstBloodType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
    }
}