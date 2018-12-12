namespace MyWinformControl
{
    partial class frmListView
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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "서울",
            "17,025",
            "605"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "동경",
            "13,650",
            "622"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "북경",
            "6,996",
            "1,368"}, -1);
            this.lstMyFavorite = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCityInfo = new System.Windows.Forms.ListView();
            this.rdoDetail = new System.Windows.Forms.RadioButton();
            this.rdoLargeIcon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstMyFavorite
            // 
            this.lstMyFavorite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstMyFavorite.FullRowSelect = true;
            listViewItem11.StateImageIndex = 0;
            this.lstMyFavorite.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lstMyFavorite.Location = new System.Drawing.Point(12, 12);
            this.lstMyFavorite.Name = "lstMyFavorite";
            this.lstMyFavorite.Size = new System.Drawing.Size(586, 128);
            this.lstMyFavorite.TabIndex = 0;
            this.lstMyFavorite.UseCompatibleStateImageBehavior = false;
            this.lstMyFavorite.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "도시구분";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "인구 밀도";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "면적(km)";
            this.columnHeader3.Width = 120;
            // 
            // lstCityInfo
            // 
            this.lstCityInfo.FullRowSelect = true;
            this.lstCityInfo.Location = new System.Drawing.Point(12, 232);
            this.lstCityInfo.Name = "lstCityInfo";
            this.lstCityInfo.Size = new System.Drawing.Size(586, 128);
            this.lstCityInfo.TabIndex = 1;
            this.lstCityInfo.UseCompatibleStateImageBehavior = false;
            this.lstCityInfo.SelectedIndexChanged += new System.EventHandler(this.lstCityInfo_SelectedIndexChanged);
            // 
            // rdoDetail
            // 
            this.rdoDetail.AutoSize = true;
            this.rdoDetail.Location = new System.Drawing.Point(24, 429);
            this.rdoDetail.Name = "rdoDetail";
            this.rdoDetail.Size = new System.Drawing.Size(59, 16);
            this.rdoDetail.TabIndex = 2;
            this.rdoDetail.TabStop = true;
            this.rdoDetail.Text = "자세히";
            this.rdoDetail.UseVisualStyleBackColor = true;
            this.rdoDetail.CheckedChanged += new System.EventHandler(this.rdoDetail_CheckedChanged);
            // 
            // rdoLargeIcon
            // 
            this.rdoLargeIcon.AutoSize = true;
            this.rdoLargeIcon.Location = new System.Drawing.Point(186, 429);
            this.rdoLargeIcon.Name = "rdoLargeIcon";
            this.rdoLargeIcon.Size = new System.Drawing.Size(75, 16);
            this.rdoLargeIcon.TabIndex = 3;
            this.rdoLargeIcon.TabStop = true;
            this.rdoLargeIcon.Text = "큰 아이콘";
            this.rdoLargeIcon.UseVisualStyleBackColor = true;
            this.rdoLargeIcon.CheckedChanged += new System.EventHandler(this.rdoLargeIcon_CheckedChanged);
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 540);
            this.Controls.Add(this.rdoLargeIcon);
            this.Controls.Add(this.rdoDetail);
            this.Controls.Add(this.lstCityInfo);
            this.Controls.Add(this.lstMyFavorite);
            this.Name = "frmListView";
            this.Text = "frmListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstMyFavorite;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstCityInfo;
        private System.Windows.Forms.RadioButton rdoDetail;
        private System.Windows.Forms.RadioButton rdoLargeIcon;
    }
}