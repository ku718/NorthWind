namespace MyWinformControl
{
    partial class FrmSearch
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
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.rdoUp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(87, 45);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(346, 21);
            this.txtSearchWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "찾을 문자 : ";
            // 
            // btnNextSearch
            // 
            this.btnNextSearch.Location = new System.Drawing.Point(457, 43);
            this.btnNextSearch.Name = "btnNextSearch";
            this.btnNextSearch.Size = new System.Drawing.Size(75, 23);
            this.btnNextSearch.TabIndex = 2;
            this.btnNextSearch.Text = "찾기";
            this.btnNextSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(56, 133);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(106, 16);
            this.chkCase.TabIndex = 4;
            this.chkCase.Text = "대/소문자 구분";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDown);
            this.groupBox1.Controls.Add(this.rdoUp);
            this.groupBox1.Location = new System.Drawing.Point(231, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // rdoDown
            // 
            this.rdoDown.AutoSize = true;
            this.rdoDown.Location = new System.Drawing.Point(95, 34);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(59, 16);
            this.rdoDown.TabIndex = 1;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "아래로";
            this.rdoDown.UseVisualStyleBackColor = true;
            // 
            // rdoUp
            // 
            this.rdoUp.AutoSize = true;
            this.rdoUp.Checked = true;
            this.rdoUp.Location = new System.Drawing.Point(16, 34);
            this.rdoUp.Name = "rdoUp";
            this.rdoUp.Size = new System.Drawing.Size(47, 16);
            this.rdoUp.TabIndex = 0;
            this.rdoUp.TabStop = true;
            this.rdoUp.Text = "위로";
            this.rdoUp.UseMnemonic = false;
            this.rdoUp.UseVisualStyleBackColor = true;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 204);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchWord);
            this.Name = "FrmSearch";
            this.Text = "FrmSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtSearchWord;
        internal System.Windows.Forms.Button btnNextSearch;
        internal System.Windows.Forms.CheckBox chkCase;
        internal System.Windows.Forms.RadioButton rdoDown;
        internal System.Windows.Forms.RadioButton rdoUp;
    }
}