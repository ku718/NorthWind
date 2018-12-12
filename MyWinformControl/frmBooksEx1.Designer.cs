namespace MyWinformControl
{
    partial class frmBooksEx1
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
            this.booksView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksView
            // 
            this.booksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksView.Location = new System.Drawing.Point(13, 13);
            this.booksView.Name = "booksView";
            this.booksView.RowTemplate.Height = 23;
            this.booksView.Size = new System.Drawing.Size(1161, 611);
            this.booksView.TabIndex = 0;
            // 
            // frmBooksEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 639);
            this.Controls.Add(this.booksView);
            this.Name = "frmBooksEx1";
            this.Text = "frmBooksEx1";
            this.Load += new System.EventHandler(this.frmBooksEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksView;
    }
}