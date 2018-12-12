namespace MyWinformControl
{
    partial class FrmNotePad
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtNotePad = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtNotePad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel2.Controls.Add(this.btnFont);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnFileOpen);
            this.splitContainer1.Size = new System.Drawing.Size(884, 522);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtNotePad
            // 
            this.txtNotePad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotePad.Location = new System.Drawing.Point(0, 0);
            this.txtNotePad.Multiline = true;
            this.txtNotePad.Name = "txtNotePad";
            this.txtNotePad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotePad.Size = new System.Drawing.Size(294, 522);
            this.txtNotePad.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 282);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(552, 76);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(15, 200);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(552, 76);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "글꼴";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(552, 73);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "파일 저장 (다른이름으로 저장)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(15, 13);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(552, 102);
            this.btnFileOpen.TabIndex = 0;
            this.btnFileOpen.Text = "파일 읽기";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.FileName = "openFileDialog1";
            this.dlgFileOpen.Filter = "텍스트파일|*.txt|모든 파일|*.*";
            // 
            // dlgFileSave
            // 
            this.dlgFileSave.Filter = "모든파일|*.*";
            // 
            // FrmNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 522);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmNotePad";
            this.Text = "FrmNotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNotePad_FormClosing);
            this.Load += new System.EventHandler(this.FrmNotePad_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtNotePad;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgFileOpen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
        private System.Windows.Forms.Button btnSearch;
    }
}