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
    public partial class FrmBindingPractice : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        public FrmBindingPractice()
        {
            InitializeComponent();
        }

        private void FrmBindingPractice_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.Categories' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                da = new SqlDataAdapter("select *from dbo.Categories", con);
                ds = new DataSet("Category");
                da.Fill(ds);  
                bindingNavigator1.BindingSource = bindingSource1;
                //bindingNavigator1.BindingSource += categoriesBindingSource; // 두개는 안댐
                bindingSource1.DataSource = ds.Tables[0];
                this.textBox1.DataBindings.Add(new Binding("text", bindingSource1, "CategoryID"));
                this.textBox2.DataBindings.Add(new Binding("text", bindingSource1, "CategoryName"));
                this.textBox3.DataBindings.Add(new Binding("text", bindingSource1, "Description"));
                this.pictureBox1.DataBindings.Add(new Binding("Image", bindingSource1, "Picture", true));

            }
        }
    }
}
