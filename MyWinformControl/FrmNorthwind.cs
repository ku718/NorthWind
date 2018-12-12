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
        SqlCommandBuilder proScb;

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

            proScb = new SqlCommandBuilder(productsAdapter);

            gCustomersView.DataSource = dataset.Tables["Customers"];
            gviewProducts.DataSource = dataset.Tables["Products"];
            gviewOrders.DataSource = dataset.Tables["Orders"];
            gOrderDetailsView.DataSource = dataset.Tables["Order Details"];

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
            DataRow dr = dataset.Tables["products"].Rows[gviewProducts.CurrentRow.Index];

            dr.BeginEdit();
            dr["productID"] = txtProProductID.Text;
            dr["productName"] = txtProductName.Text;
            dr["discontinued"] = BoolToNumber(chkDiscontinued.Checked);
            dr.EndEdit();

            DataSet change = dataset.GetChanges(DataRowState.Modified);
            if (change.HasErrors)
            {
                MessageBox.Show("제약 조건에 이상");
            }
            else
            {
                try
                {
                    productsAdapter.Update(change.Tables["products"]);
                    dataset.AcceptChanges();
                }
                catch (SqlException sq)
                {
                    MessageBox.Show(sq.Message);
                    dataset.RejectChanges();
                }
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            DataRow dr = dataset.Tables["products"].Rows[gviewProducts.CurrentRow.Index];

            dr.Delete();
            try
            {
                productsAdapter.Update(dataset.Tables["products"]);
                dataset.AcceptChanges();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
                dataset.RejectChanges();
            }
        }

        private void btnProSave_Click(object sender, EventArgs e)
        {
            DataRow dr = dataset.Tables["products"].NewRow();
            dr["productID"] = this.txtProProductID.Text;
            dr["productName"] = this.txtProductName.Text;
            dr["discontinued"] = BoolToNumber(chkDiscontinued.Checked);

            dataset.Tables["products"].Rows.Add(dr);

            try
            {
                productsAdapter.Update(dataset.Tables["products"]);
                dataset.AcceptChanges();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
                dataset.RejectChanges();
            }
        }
        private int BoolToNumber(bool flag)
        {
            if (flag)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void gviewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow select = dataset.Tables["products"].Rows[e.RowIndex];
            txtProProductID.Text = select["productID"].ToString();
            txtProductName.Text = select["productName"].ToString();
            chkDiscontinued.Checked = (bool)select["discontinued"];
        }

        #region Customers
        private void gCustomersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gCustomersView.SelectedRows != null && gCustomersView.SelectedRows.Count == 1)
            {
                DataRow dr = dataset.Tables["Customers"].Rows[e.RowIndex];
                txtCustomerId.Text = dr["CustomerID"].ToString();
                txtCustomerCompanyName.Text = dr["CompanyName"].ToString();
                txtCustomerContactName.Text = dr["ContactName"].ToString();

            }
        }

        private void btnCustomersInsert_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataset.Tables["Customers"].NewRow();
            newRow["CustomerID"] = txtCustomerId.Text;
            newRow["CompanyName"] = txtCustomerCompanyName.Text;
            newRow["ContactName"] = txtCustomerContactName.Text;

            dataset.Tables["Customers"].Rows.Add(newRow);

            SqlCommandBuilder sb = new SqlCommandBuilder(customersAdapter);

            try
            {
                customersAdapter.Update(dataset, "Customers");
                dataset.AcceptChanges();
                FrmNorthwind_Load(null, null);
            }
            catch (Exception)
            {
                dataset.RejectChanges();
            }
        }

        private void btnCustomersDelete_Click(object sender, EventArgs e)
        {
            DataRow targetRow = dataset.Tables["Customers"].Rows[gCustomersView.CurrentRow.Index];// friendsTable.Rows[index];

            // 메세지 박스 띄워서 지울까요? 예 아니오
            targetRow.Delete();

            SqlCommandBuilder sb = new SqlCommandBuilder(customersAdapter);

            try
            {
                customersAdapter.Update(dataset, "Customers");
                dataset.AcceptChanges();

                ClearCustomersFiled();
                FrmNorthwind_Load(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("삭제 실패");
                dataset.RejectChanges(); // rollback
            }
        }

        private void btnCustomersUpdate_Click(object sender, EventArgs e)
        {
            DataRow targetRow = dataset.Tables["Customers"].Rows[gCustomersView.CurrentRow.Index];

            targetRow.BeginEdit(); // 변경된 사항이 있는지 추적
            targetRow["CustomerID"] = txtCustomerId.Text;
            targetRow["CompanyName"] = txtCustomerCompanyName.Text;
            targetRow["ContactName"] = txtCustomerContactName.Text;
            targetRow.EndEdit(); // 여기까지

            SqlCommandBuilder sb = new SqlCommandBuilder(customersAdapter);

            try
            {
                customersAdapter.Update(dataset, "Customers");
                dataset.AcceptChanges();

                ClearCustomersFiled();
                FrmNorthwind_Load(null, null);
            }
            catch (Exception)
            {
                dataset.RejectChanges();
            }
        }

        private void ClearCustomersFiled()
        {
            txtCustomerId.Text = String.Empty;
            txtCustomerCompanyName.Text = String.Empty;
            txtCustomerContactName.Text = String.Empty;
        }

        private void gCustomersView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            if (e.Exception.Message.ToString().ToLower().Contains("foreignkey"))
            {
                MessageBox.Show("부모 레코드가 있어야 합니다");
                return;
            }
        }
        #endregion

        #region Order Details
        private void gOrderDetailsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gOrderDetailsView.SelectedRows != null && gOrderDetailsView.SelectedRows.Count == 1)
            {
                DataRow dr = dataset.Tables["Order Details"].Rows[e.RowIndex];
                txtOrderDetailsOrderID.Text = dr["OrderID"].ToString();
                txtOrderDetailsProductID.Text = dr["ProductID"].ToString();
                txtOrderDetailsUnitPrice.Text = dr["UnitPrice"].ToString();
                txtOrderDetailsQuantity.Text = dr["Quantity"].ToString();
                txtOrderDetailsDiscount.Text = dr["Discount"].ToString();
            }
        }

        private void btnOrderDetailsInsert_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataset.Tables["Order Details"].NewRow();
            newRow["OrderID"] = txtOrderDetailsOrderID.Text;
            newRow["ProductID"] = txtOrderDetailsProductID.Text;
            newRow["UnitPrice"] = txtOrderDetailsUnitPrice.Text;
            newRow["Quantity"] = txtOrderDetailsQuantity.Text;
            newRow["Discount"] = txtOrderDetailsDiscount.Text;

            try
            {
                dataset.Tables["Order Details"].Rows.Add(newRow);

                SqlCommandBuilder sb = new SqlCommandBuilder(orderDetailsAdapter);

                try
                {
                    orderDetailsAdapter.Update(dataset, "Order Details");
                    dataset.AcceptChanges();
                    ClearOrderDetailsFiled();
                    FrmNorthwind_Load(null, null);
                }
                catch (Exception ek)
                {
                    MessageBox.Show("Primary Key가 중복되었습니다.");
                    dataset.RejectChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("부모키가 등록되어 있어야 합니다.");
            }


        }

        private void btnOrderDetailsDelete_Click(object sender, EventArgs e)
        {
            DataRow targetRow = dataset.Tables["Order Details"].Rows[gOrderDetailsView.CurrentRow.Index];

            targetRow.Delete();

            SqlCommandBuilder sb = new SqlCommandBuilder(orderDetailsAdapter);

            try
            {
                orderDetailsAdapter.Update(dataset, "Order Details");
                dataset.AcceptChanges();
                ClearOrderDetailsFiled();
                FrmNorthwind_Load(null, null);

            }
            catch (Exception)
            {
                dataset.RejectChanges();
            }
        }

        private void btnOrderDetailsUpdate_Click(object sender, EventArgs e)
        {
            DataRow targetRow = dataset.Tables["Order Details"].Rows[gOrderDetailsView.CurrentRow.Index];
            try
            {
                targetRow.BeginEdit(); // 변경된 사항이 있는지 추적
                targetRow["OrderID"] = txtOrderDetailsOrderID.Text;
                targetRow["ProductID"] = txtOrderDetailsProductID.Text;
                targetRow["UnitPrice"] = txtOrderDetailsUnitPrice.Text;
                targetRow["Quantity"] = txtOrderDetailsQuantity.Text;
                targetRow["Discount"] = txtOrderDetailsDiscount.Text;
                targetRow.EndEdit(); // 여기까지

                SqlCommandBuilder sb = new SqlCommandBuilder(orderDetailsAdapter);

                try
                {
                    orderDetailsAdapter.Update(dataset, "Order Details");
                    dataset.AcceptChanges();

                    ClearCustomersFiled();
                    FrmNorthwind_Load(null, null);
                }
                catch (Exception)
                {
                    dataset.RejectChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("부모키가 등록되어 있어햐 합니다");
            }

        }

        private void ClearOrderDetailsFiled()
        {
            txtOrderDetailsOrderID.Text = String.Empty;
            txtOrderDetailsProductID.Text = String.Empty;
            txtOrderDetailsUnitPrice.Text = String.Empty;
            txtOrderDetailsQuantity.Text = String.Empty;
            txtOrderDetailsDiscount.Text = String.Empty;
        }

        private void gOrderDetailsView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            if (e.Exception.Message.ToString().ToLower().Contains("foreignkey"))
            {
                MessageBox.Show("부모 레코드가 있어야 합니다");
                return;
            }
        }
        #endregion
    }
}
