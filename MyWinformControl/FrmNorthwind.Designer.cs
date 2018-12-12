﻿namespace MyWinformControl
{
    partial class FrmNorthwind
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
            this.gviewProducts = new System.Windows.Forms.DataGridView();
            this.gviewOrderDetails = new System.Windows.Forms.DataGridView();
            this.gviewOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusCustomerID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCusUpdate = new System.Windows.Forms.Button();
            this.btnCusDelete = new System.Windows.Forms.Button();
            this.btnCusSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProSave = new System.Windows.Forms.Button();
            this.btnProDelete = new System.Windows.Forms.Button();
            this.btnProUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProProductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOrdSave = new System.Windows.Forms.Button();
            this.btnOrdDelete = new System.Windows.Forms.Button();
            this.btnOrdUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrdOrderID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOrdCustomerID = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnODSave = new System.Windows.Forms.Button();
            this.btnODDelete = new System.Windows.Forms.Button();
            this.btnODUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtODOrderID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtODProductID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gviewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gviewCustomers
            // 
            this.gviewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewCustomers.Location = new System.Drawing.Point(12, 36);
            this.gviewCustomers.Name = "gviewCustomers";
            this.gviewCustomers.RowTemplate.Height = 23;
            this.gviewCustomers.Size = new System.Drawing.Size(268, 253);
            this.gviewCustomers.TabIndex = 1;
            // 
            // gviewProducts
            // 
            this.gviewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewProducts.Location = new System.Drawing.Point(343, 36);
            this.gviewProducts.Name = "gviewProducts";
            this.gviewProducts.RowTemplate.Height = 23;
            this.gviewProducts.Size = new System.Drawing.Size(268, 253);
            this.gviewProducts.TabIndex = 2;
            // 
            // gviewOrderDetails
            // 
            this.gviewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewOrderDetails.Location = new System.Drawing.Point(343, 346);
            this.gviewOrderDetails.Name = "gviewOrderDetails";
            this.gviewOrderDetails.RowTemplate.Height = 23;
            this.gviewOrderDetails.Size = new System.Drawing.Size(268, 253);
            this.gviewOrderDetails.TabIndex = 3;
            // 
            // gviewOrders
            // 
            this.gviewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewOrders.Location = new System.Drawing.Point(12, 346);
            this.gviewOrders.Name = "gviewOrders";
            this.gviewOrders.RowTemplate.Height = 23;
            this.gviewOrders.Size = new System.Drawing.Size(268, 253);
            this.gviewOrders.TabIndex = 4;
            this.gviewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gviewOrders_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "OrderDetails";
            // 
            // txtCusCustomerID
            // 
            this.txtCusCustomerID.Location = new System.Drawing.Point(103, 64);
            this.txtCusCustomerID.Name = "txtCusCustomerID";
            this.txtCusCustomerID.Size = new System.Drawing.Size(100, 21);
            this.txtCusCustomerID.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(104, 103);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 21);
            this.txtCompanyName.TabIndex = 10;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(104, 142);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 21);
            this.txtContactName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "CustomerID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "CompanyName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "ContactName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCusSave);
            this.groupBox1.Controls.Add(this.btnCusDelete);
            this.groupBox1.Controls.Add(this.btnCusUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCusCustomerID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.txtContactName);
            this.groupBox1.Location = new System.Drawing.Point(638, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 253);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // btnCusUpdate
            // 
            this.btnCusUpdate.Location = new System.Drawing.Point(8, 188);
            this.btnCusUpdate.Name = "btnCusUpdate";
            this.btnCusUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCusUpdate.TabIndex = 15;
            this.btnCusUpdate.Text = "Update";
            this.btnCusUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.Location = new System.Drawing.Point(89, 188);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCusDelete.TabIndex = 16;
            this.btnCusDelete.Text = "Delete";
            this.btnCusDelete.UseVisualStyleBackColor = true;
            // 
            // btnCusSave
            // 
            this.btnCusSave.Location = new System.Drawing.Point(13, 217);
            this.btnCusSave.Name = "btnCusSave";
            this.btnCusSave.Size = new System.Drawing.Size(151, 23);
            this.btnCusSave.TabIndex = 17;
            this.btnCusSave.Text = "Save";
            this.btnCusSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDiscontinued);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnProSave);
            this.groupBox2.Controls.Add(this.btnProDelete);
            this.groupBox2.Controls.Add(this.btnProUpdate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProProductID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Location = new System.Drawing.Point(875, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 253);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // btnProSave
            // 
            this.btnProSave.Location = new System.Drawing.Point(13, 217);
            this.btnProSave.Name = "btnProSave";
            this.btnProSave.Size = new System.Drawing.Size(151, 23);
            this.btnProSave.TabIndex = 17;
            this.btnProSave.Text = "Save";
            this.btnProSave.UseVisualStyleBackColor = true;
            this.btnProSave.Click += new System.EventHandler(this.btnProSave_Click);
            // 
            // btnProDelete
            // 
            this.btnProDelete.Location = new System.Drawing.Point(89, 188);
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProDelete.TabIndex = 16;
            this.btnProDelete.Text = "Delete";
            this.btnProDelete.UseVisualStyleBackColor = true;
            this.btnProDelete.Click += new System.EventHandler(this.btnProDelete_Click);
            // 
            // btnProUpdate
            // 
            this.btnProUpdate.Location = new System.Drawing.Point(8, 188);
            this.btnProUpdate.Name = "btnProUpdate";
            this.btnProUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProUpdate.TabIndex = 15;
            this.btnProUpdate.Text = "Update";
            this.btnProUpdate.UseVisualStyleBackColor = true;
            this.btnProUpdate.Click += new System.EventHandler(this.btnProUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "ProductID";
            // 
            // txtProProductID
            // 
            this.txtProProductID.Location = new System.Drawing.Point(103, 64);
            this.txtProProductID.Name = "txtProProductID";
            this.txtProProductID.Size = new System.Drawing.Size(100, 21);
            this.txtProProductID.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "ProductName";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(104, 103);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 21);
            this.txtProductName.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOrdSave);
            this.groupBox3.Controls.Add(this.btnOrdDelete);
            this.groupBox3.Controls.Add(this.btnOrdUpdate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtOrdOrderID);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtOrdCustomerID);
            this.groupBox3.Controls.Add(this.txtShipName);
            this.groupBox3.Location = new System.Drawing.Point(638, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 253);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // btnOrdSave
            // 
            this.btnOrdSave.Location = new System.Drawing.Point(13, 217);
            this.btnOrdSave.Name = "btnOrdSave";
            this.btnOrdSave.Size = new System.Drawing.Size(151, 23);
            this.btnOrdSave.TabIndex = 17;
            this.btnOrdSave.Text = "Save";
            this.btnOrdSave.UseVisualStyleBackColor = true;
            this.btnOrdSave.Click += new System.EventHandler(this.btnOrdSave_Click);
            // 
            // btnOrdDelete
            // 
            this.btnOrdDelete.Location = new System.Drawing.Point(89, 188);
            this.btnOrdDelete.Name = "btnOrdDelete";
            this.btnOrdDelete.Size = new System.Drawing.Size(75, 23);
            this.btnOrdDelete.TabIndex = 16;
            this.btnOrdDelete.Text = "Delete";
            this.btnOrdDelete.UseVisualStyleBackColor = true;
            this.btnOrdDelete.Click += new System.EventHandler(this.btnOrdDelete_Click);
            // 
            // btnOrdUpdate
            // 
            this.btnOrdUpdate.Location = new System.Drawing.Point(8, 188);
            this.btnOrdUpdate.Name = "btnOrdUpdate";
            this.btnOrdUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnOrdUpdate.TabIndex = 15;
            this.btnOrdUpdate.Text = "Update";
            this.btnOrdUpdate.UseVisualStyleBackColor = true;
            this.btnOrdUpdate.Click += new System.EventHandler(this.btnOrdUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "OrderID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "ShipName";
            // 
            // txtOrdOrderID
            // 
            this.txtOrdOrderID.Location = new System.Drawing.Point(103, 64);
            this.txtOrdOrderID.Name = "txtOrdOrderID";
            this.txtOrdOrderID.Size = new System.Drawing.Size(100, 21);
            this.txtOrdOrderID.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "CustomerID";
            // 
            // txtOrdCustomerID
            // 
            this.txtOrdCustomerID.Location = new System.Drawing.Point(104, 103);
            this.txtOrdCustomerID.Name = "txtOrdCustomerID";
            this.txtOrdCustomerID.Size = new System.Drawing.Size(100, 21);
            this.txtOrdCustomerID.TabIndex = 10;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(104, 142);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(100, 21);
            this.txtShipName.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDiscount);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btnODSave);
            this.groupBox4.Controls.Add(this.btnODDelete);
            this.groupBox4.Controls.Add(this.btnODUpdate);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtODOrderID);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtODProductID);
            this.groupBox4.Controls.Add(this.txtUnitPrice);
            this.groupBox4.Location = new System.Drawing.Point(875, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 253);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OrderDetails";
            // 
            // btnODSave
            // 
            this.btnODSave.Location = new System.Drawing.Point(13, 217);
            this.btnODSave.Name = "btnODSave";
            this.btnODSave.Size = new System.Drawing.Size(151, 23);
            this.btnODSave.TabIndex = 17;
            this.btnODSave.Text = "Save";
            this.btnODSave.UseVisualStyleBackColor = true;
            // 
            // btnODDelete
            // 
            this.btnODDelete.Location = new System.Drawing.Point(89, 188);
            this.btnODDelete.Name = "btnODDelete";
            this.btnODDelete.Size = new System.Drawing.Size(75, 23);
            this.btnODDelete.TabIndex = 16;
            this.btnODDelete.Text = "Delete";
            this.btnODDelete.UseVisualStyleBackColor = true;
            // 
            // btnODUpdate
            // 
            this.btnODUpdate.Location = new System.Drawing.Point(8, 188);
            this.btnODUpdate.Name = "btnODUpdate";
            this.btnODUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnODUpdate.TabIndex = 15;
            this.btnODUpdate.Text = "Update";
            this.btnODUpdate.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "OrderID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "UnitPrice";
            // 
            // txtODOrderID
            // 
            this.txtODOrderID.Location = new System.Drawing.Point(102, 14);
            this.txtODOrderID.Name = "txtODOrderID";
            this.txtODOrderID.Size = new System.Drawing.Size(100, 21);
            this.txtODOrderID.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "ProductID";
            // 
            // txtODProductID
            // 
            this.txtODProductID.Location = new System.Drawing.Point(103, 49);
            this.txtODProductID.Name = "txtODProductID";
            this.txtODProductID.Size = new System.Drawing.Size(100, 21);
            this.txtODProductID.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(103, 84);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Discontinued";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(102, 119);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(102, 154);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 21);
            this.txtDiscount.TabIndex = 21;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(103, 141);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.chkDiscontinued.TabIndex = 19;
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // FrmNorthwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 631);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gviewOrders);
            this.Controls.Add(this.gviewOrderDetails);
            this.Controls.Add(this.gviewProducts);
            this.Controls.Add(this.gviewCustomers);
            this.Name = "FrmNorthwind";
            this.Text = "FrmNorthwind";
            this.Load += new System.EventHandler(this.FrmNorthwind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gviewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gviewCustomers;
        private System.Windows.Forms.DataGridView gviewProducts;
        private System.Windows.Forms.DataGridView gviewOrderDetails;
        private System.Windows.Forms.DataGridView gviewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusCustomerID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCusSave;
        private System.Windows.Forms.Button btnCusDelete;
        private System.Windows.Forms.Button btnCusUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProSave;
        private System.Windows.Forms.Button btnProDelete;
        private System.Windows.Forms.Button btnProUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProProductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOrdSave;
        private System.Windows.Forms.Button btnOrdDelete;
        private System.Windows.Forms.Button btnOrdUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrdOrderID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOrdCustomerID;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnODSave;
        private System.Windows.Forms.Button btnODDelete;
        private System.Windows.Forms.Button btnODUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtODOrderID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtODProductID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.CheckBox chkDiscontinued;
    }
}