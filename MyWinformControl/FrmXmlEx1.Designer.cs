namespace MyWinformControl
{
    partial class FrmXmlEx1
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
            this.friendView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.friendView)).BeginInit();
            this.SuspendLayout();
            // 
            // friendView
            // 
            this.friendView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendView.Location = new System.Drawing.Point(13, 13);
            this.friendView.Name = "friendView";
            this.friendView.RowTemplate.Height = 23;
            this.friendView.Size = new System.Drawing.Size(775, 425);
            this.friendView.TabIndex = 0;
            // 
            // FrmXmlEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.friendView);
            this.Name = "FrmXmlEx1";
            this.Text = "FrmXmlEx1";
            this.Load += new System.EventHandler(this.FrmXmlEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView friendView;
    }
}