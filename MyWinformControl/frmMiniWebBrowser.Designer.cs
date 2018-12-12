namespace MyWinformControl
{
    partial class frmMiniWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiniWebBrowser));
            this.myWeb = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.txtWebSource = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myWeb
            // 
            this.myWeb.Dock = System.Windows.Forms.DockStyle.Left;
            this.myWeb.Location = new System.Drawing.Point(0, 0);
            this.myWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWeb.Name = "myWeb";
            this.myWeb.Size = new System.Drawing.Size(535, 647);
            this.myWeb.TabIndex = 0;
            this.myWeb.Url = new System.Uri("", System.UriKind.Relative);
            this.myWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.myWeb_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrev,
            this.btnNext,
            this.btnReload,
            this.txtUrl,
            this.btnGo});
            this.toolStrip1.Location = new System.Drawing.Point(535, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(436, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 22);
            this.btnPrev.Text = "뒤로";
            this.btnPrev.Click += new System.EventHandler(this.MyBtnClick);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 22);
            this.btnNext.Text = "앞으로";
            this.btnNext.Click += new System.EventHandler(this.MyBtnClick);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(59, 19);
            this.btnReload.Text = "새로고침";
            this.btnReload.Click += new System.EventHandler(this.MyBtnClick);
            // 
            // txtUrl
            // 
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 23);
            this.txtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(35, 19);
            this.btnGo.Text = "이동";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtWebSource
            // 
            this.txtWebSource.Location = new System.Drawing.Point(535, 28);
            this.txtWebSource.Multiline = true;
            this.txtWebSource.Name = "txtWebSource";
            this.txtWebSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWebSource.Size = new System.Drawing.Size(416, 307);
            this.txtWebSource.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(542, 342);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "제목 : ";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(542, 386);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(37, 12);
            this.lblAddr.TabIndex = 4;
            this.lblAddr.Text = "주소 :";
            // 
            // frmMiniWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 647);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtWebSource);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.myWeb);
            this.Name = "frmMiniWebBrowser";
            this.Text = "frmMiniWebBrowser";
            this.Load += new System.EventHandler(this.frmMiniWebBrowser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser myWeb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.TextBox txtWebSource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddr;
    }
}