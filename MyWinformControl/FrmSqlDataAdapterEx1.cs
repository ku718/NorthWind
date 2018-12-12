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
    public partial class FrmSqlDataAdapterEx1 : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        public FrmSqlDataAdapterEx1()
        {
            InitializeComponent();
        }

        private void FrmSqlDataAdapterEx1_Load(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=DESKTOP-LNQ5TIB;User ID=northwind_kun;Password=1234";

            adapter = new SqlDataAdapter("select *from dbo.employees", connectionStr);
            
            // Dataset : 메모리 안의 테이블
            ds = new DataSet();

            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sb = new SqlCommandBuilder(adapter);

            adapter.Update(ds);

        }
    }
}
