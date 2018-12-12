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
    public partial class FrmDataRelationEx1 : Form
    {
        SqlDataAdapter custAdapter;
        SqlDataAdapter orderAdapter;
        DataSet dataSet;

        public FrmDataRelationEx1()
        {
            InitializeComponent();
        }

        private void FrmDataRelationEx1_Load(object sender, EventArgs e)
        {
            string conStr = Properties.Settings.Default.ConnectionString.ToString();


            // 두 테이블을 가져올 SqlAdapter객체 생성
            custAdapter = new SqlDataAdapter("select *from dbo.Customers", conStr);
            orderAdapter = new SqlDataAdapter("select *from dbo.Orders", conStr);

            // DataSet 생성
            dataSet = new DataSet();

            // Adapter객체로부터 DataSet 채우기
            custAdapter.Fill(dataSet, "Customers");
            orderAdapter.Fill(dataSet, "Orders");


            // DataSet 안의 두 테이블에 관계 객체 만들기
            DataRelation custOrderRelation = new DataRelation("Customers", dataSet.Tables["Customers"].Columns["CustomerID"], dataSet.Tables["Orders"].Columns["CustomerID"]);  // DataRelation 객체 생성

            dataSet.Relations.Add(custOrderRelation);   // Dataset 에 관계(DataRelation)를 추가해줌


            gviewCustomers.DataSource = dataSet.Tables["Customers"];
            gviewOrders.DataSource = dataSet.Tables["Orders"];


            foreach (DataRow custRow in dataSet.Tables["Customers"].Rows)
            {   // 고객
                this.textBox1.Text += "Customer ID : " + custRow["CustomerID"] + "\r\n";

                foreach (DataRow order in custRow.GetChildRows(custOrderRelation))
                {   // 그 고객이 주문한 내역
                    this.textBox1.Text += "주문 번호 : " + order["OrderID"] +"\r\n";
                }
                this.textBox1.Text += "---------------------------------------------\r\n"; 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder odcommandBuilder = new SqlCommandBuilder(orderAdapter);


            orderAdapter.Update(dataSet, "Orders");


            gviewCustomers.DataSource = null;
            gviewOrders.DataSource = null;

            FrmDataRelationEx1_Load(null, null);
        }

        /// <summary>
        /// 그리드뷰에서 데이터가 갱신될 때 예외가 나면 호출되는 이벤트핸들러  (다양한 예외)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void gviewOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            if (e.Exception.Message.ToString().ToLower().Contains("foreignkey"))
            {
                MessageBox.Show("부모 레코드가 있어야 합니다");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder custcommandBuilder = new SqlCommandBuilder(custAdapter);
            custAdapter.Update(dataSet, "Customers");


            gviewCustomers.DataSource = null;
            gviewOrders.DataSource = null;

            FrmDataRelationEx1_Load(null, null);
        }
    }
}
