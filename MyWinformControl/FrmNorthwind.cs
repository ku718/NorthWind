using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class FrmNorthwind : Form
    {
        SqlDataAdapter productsAdapter;
        SqlDataAdapter orderDetailsAdapter;
        SqlDataAdapter ordersAdapter;
        SqlDataAdapter customersAdapter;
        DataSet dataset;

        public FrmNorthwind()
        {
            InitializeComponent();
        }

        private void FrmNorthwind_Load(object sender, EventArgs e)
        {
            string conStr = Properties.Settings.Default.ConnectionString.ToString();


            customersAdapter = new SqlDataAdapter("select *from dbo.Customers", conStr);
            ordersAdapter = new SqlDataAdapter("select *from dbo.Orders", conStr);
            orderDetailsAdapter = new SqlDataAdapter("select *from dbo.[Order Details]", conStr);
            productsAdapter = new SqlDataAdapter("select *from dbo.Products", conStr);

            dataset = new DataSet();


            customersAdapter.Fill(dataset, "Customers");
            ordersAdapter.Fill(dataset, "Orders");
            orderDetailsAdapter.Fill(dataset, "Order Details");
            productsAdapter.Fill(dataset, "Products");

            DataRelation custOrderRelation = new DataRelation("Customers", dataset.Tables["Customers"].Columns["CustomerID"], dataset.Tables["Orders"].Columns["CustomerID"]);
            DataRelation ordersRelation = new DataRelation("Orders", dataset.Tables["Orders"].Columns["OrderID"], dataset.Tables["Order Details"].Columns["OrderID"]);
            DataRelation productsRelation = new DataRelation("Products", dataset.Tables["Products"].Columns["ProductID"], dataset.Tables["Order Details"].Columns["ProductID"]);

            dataset.Relations.Add(custOrderRelation);
            dataset.Relations.Add(ordersRelation);
            dataset.Relations.Add(productsRelation);



            gviewCustomers.DataSource = dataset.Tables["Customers"];
            gviewProducts.DataSource = dataset.Tables["Products"];
            gviewOrders.DataSource = dataset.Tables["Orders"];
            gviewOrderDetails.DataSource = dataset.Tables["Order Details"];

        }

        private void btnOrdUpdate_Click(object sender, EventArgs e)
        {
            DataRow udRow = dataset.Tables["Orders"].Rows[gviewOrders.CurrentRow.Index];
            udRow.BeginEdit();
            udRow["OrderID"] = txtOrdOrderID.Text;
            udRow["CustomerID"] = txtOrdCustomerID.Text;
            udRow["ShipName"] = txtShipName.Text;
            udRow.EndEdit();
            SqlCommandBuilder sb = new SqlCommandBuilder(ordersAdapter);

            if (udRow.HasErrors)
            {
                MessageBox.Show("외래키 제약조건 에러");
            }
            else
            {
                try
                {
                    ordersAdapter.Update(dataset, "Orders");
                    dataset.AcceptChanges();
                    FrmNorthwind_Load(null, null);
                    this.txtOrdCustomerID.Text = this.txtOrdOrderID.Text = this.txtShipName.Text = String.Empty;

                }
                catch (Exception)
                {
                    MessageBox.Show("수정 실패");
                    dataset.RejectChanges();
                }
            }
        }

        private void btnOrdDelete_Click(object sender, EventArgs e)
        {
            DataRow delRow = dataset.Tables["Orders"].Rows[gviewOrders.CurrentRow.Index];
            delRow.Delete();

            SqlCommandBuilder sb = new SqlCommandBuilder(ordersAdapter);

            if (delRow.HasErrors)
            {
                MessageBox.Show("외래키 제약조건 에러");
            }
            else
            {

                try
                {
                    ordersAdapter.Update(dataset, "Orders");
                    dataset.AcceptChanges();
                    FrmNorthwind_Load(null, null);
                    this.txtOrdCustomerID.Text = this.txtOrdOrderID.Text = this.txtShipName.Text = String.Empty;

                }
                catch (Exception)
                {
                    MessageBox.Show("삭제 실패");
                    dataset.RejectChanges();
                }
            }

        }

        private void btnOrdSave_Click(object sender, EventArgs e)
        {
            DataRow newOrder = dataset.Tables["Orders"].NewRow();

            newOrder["OrderID"] = txtOrdOrderID.Text;
            newOrder["CustomerID"] = txtOrdCustomerID.Text;
            newOrder["ShipName"] = txtShipName.Text;

            dataset.Tables["Orders"].Rows.Add(newOrder);

            SqlCommandBuilder sb = new SqlCommandBuilder(ordersAdapter);

            if (newOrder.HasErrors)
            {
                MessageBox.Show("외래키 제약조건 에러");
            }
            else
            {
                try
                {
                    ordersAdapter.Update(dataset, "Orders");
                    dataset.AcceptChanges();
                    FrmNorthwind_Load(null, null);
                    this.txtOrdCustomerID.Text = this.txtOrdOrderID.Text = this.txtShipName.Text = String.Empty;
                }
                catch (SqlException)
                {
                    MessageBox.Show("저장 실패");
                    dataset.RejectChanges();
                }
            }
        }

        private void gviewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow select = dataset.Tables["Orders"].Rows[e.RowIndex];
            txtOrdCustomerID.Text = select["CustomerID"].ToString();
            txtShipName.Text = select["ShipName"].ToString();
            txtOrdOrderID.Text = select["OrderID"].ToString();
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnProSave_Click(object sender, EventArgs e)
        {


        }
    }
}
