using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class FrmBindingNavigator2 : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        public FrmBindingNavigator2()
        {
            InitializeComponent();
        }

        private void FrmBindingNavigator2_Load(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyWinformControl.Properties.Settings.ConnectionString"].ConnectionString))


            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                da = new SqlDataAdapter("select *from dbo.employees", con);
                ds = new DataSet("EmployeeSet2");
                da.Fill(ds);    // 어댑터로부터 데이터셋 채움
                bindingNavigator1.BindingSource = bindingSource1;   // 네비게이터의 바인딩 대상을 지정

                bindingSource1.DataSource = ds.Tables[0];   // 바인딩 소스에 DataSe의 Employees 테이블 연결

                this.txtEmployeeID.DataBindings.Add(new Binding("Text", bindingSource1, "EmployeeID"));
                this.txtLastName.DataBindings.Add(new Binding("Text", bindingSource1, "LastName"));
                this.txtFirstName.DataBindings.Add(new Binding("Text", bindingSource1, "FirstName"));
                this.txtTitle.DataBindings.Add(new Binding("Text", bindingSource1, "Title"));
                this.txtTitleOfCourtesy.DataBindings.Add(new Binding("Text", bindingSource1, "TitleOfCourtesy"));
                this.txtAddress.DataBindings.Add(new Binding("Text", bindingSource1, "Address"));
                this.txtCity.DataBindings.Add(new Binding("Text", bindingSource1, "City"));
                this.txtRegion.DataBindings.Add(new Binding("Text", bindingSource1, "Region"));
                this.txtPostalCode.DataBindings.Add(new Binding("Text", bindingSource1, "PostalCode"));
                this.txtCountry.DataBindings.Add(new Binding("Text", bindingSource1, "Country"));
                this.txtHomePhone.DataBindings.Add(new Binding("Text", bindingSource1, "HomePhone"));
                this.txtExtension.DataBindings.Add(new Binding("Text", bindingSource1, "Extension"));
                this.txtNotes.DataBindings.Add(new Binding("Text", bindingSource1, "Notes"));
                this.txtReportsTo.DataBindings.Add(new Binding("Text", bindingSource1, "ReportsTo"));
                this.txtPhotoPath.DataBindings.Add(new Binding("Text", bindingSource1, "PhotoPath"));
                this.pictureBox1.DataBindings.Add(new Binding("Image", bindingSource1, "Photo", true));
                this.calBirthDate.DataBindings.Add(new Binding("SelectionRange", bindingSource1, "BirthDate",true));
                this.calHireDate.DataBindings.Add(new Binding("SelectionRange", bindingSource1, "HireDate",true));



                byte[] imgBytes = (byte[])ds.Tables[0].Rows[0]["Photo"];
                MemoryStream ms = new MemoryStream(imgBytes);
                pictureBox2.Image = Image.FromStream(ms);

            }
        }
    }
}
