namespace MyWinformControl
{
    partial class FrmDataRelationEx1
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
            this.gviewCustomers = new System.Windows.Forms.DataGridView();
            this.gviewOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gviewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gviewCustomers
            // 
            this.gviewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewCustomers.Location = new System.Drawing.Point(31, 45);
            this.gviewCustomers.Name = "gviewCustomers";
            this.gviewCustomers.RowTemplate.Height = 23;
            this.gviewCustomers.Size = new System.Drawing.Size(843, 189);
            this.gviewCustomers.TabIndex = 0;
            // 
            // gviewOrders
            // 
            this.gviewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewOrders.Location = new System.Drawing.Point(31, 283);
            this.gviewOrders.Name = "gviewOrders";
            this.gviewOrders.RowTemplate.Height = 23;
            this.gviewOrders.Size = new System.Drawing.Size(843, 189);
            this.gviewOrders.TabIndex = 1;
            this.gviewOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gviewOrders_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "고객 테이블";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "주문 테이블";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(799, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "업데이트";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "업데이트";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(899, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 427);
            this.textBox1.TabIndex = 6;
            // 
            // FrmDataRelationEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 571);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gviewOrders);
            this.Controls.Add(this.gviewCustomers);
            this.Name = "FrmDataRelationEx1";
            this.Text = "FrmDataRelationEx1";
            this.Load += new System.EventHandler(this.FrmDataRelationEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gviewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gviewCustomers;
        private System.Windows.Forms.DataGridView gviewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}