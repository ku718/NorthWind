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
    public partial class frmSqlConnect : Form
    {
        public frmSqlConnect()
        {
            InitializeComponent();
        }

        private void frmSqlConnect_Load(object sender, EventArgs e)
        {
            string connectioin = "Data Source=DESKTOP-LNQ5TIB;User ID=gordon;Password=7777777";
            using (SqlConnection con = new SqlConnection(connectioin))
            {

                con.Open();
                con.Close();
            }
        }
    }
}
