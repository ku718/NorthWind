namespace MyWinformControl
{
    partial class frmTreeView
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
            this.myTreeView2 = new System.Windows.Forms.TreeView();
            this.myTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myTreeView2
            // 
            this.myTreeView2.Location = new System.Drawing.Point(385, 12);
            this.myTreeView2.Name = "myTreeView2";
            this.myTreeView2.Size = new System.Drawing.Size(353, 426);
            this.myTreeView2.TabIndex = 0;
            this.myTreeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // myTreeView
            // 
            this.myTreeView.Location = new System.Drawing.Point(12, 13);
            this.myTreeView.Name = "myTreeView";
            this.myTreeView.Size = new System.Drawing.Size(355, 426);
            this.myTreeView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "모든 노드 출력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 3;
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myTreeView);
            this.Controls.Add(this.myTreeView2);
            this.Name = "frmTreeView";
            this.Text = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView myTreeView2;
        private System.Windows.Forms.TreeView myTreeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}