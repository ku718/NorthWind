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
    public partial class FrmImageToPictureBox : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        string imgFileName;
        public FrmImageToPictureBox()
        {
            InitializeComponent();
        }

        private void FrmImageToPictureBox_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings
                ["MyWinformControl.Properties.Settings.ConnectionString"].ConnectionString;

            da = new SqlDataAdapter("Select *from dbo.Employees", conStr);
            ds = new DataSet();
            da.Fill(ds, "employees");

            dataGridView1.DataSource = ds.Tables["employees"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (DialogResult != DialogResult.Cancel)
            {
                imgFileName = openFileDialog1.FileName;
            }
            pictureBox2.ImageLocation = imgFileName;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow newRow = ds.Tables["employees"].NewRow();
            newRow["EmployeeID"] = textBox1.Text;
            newRow["LastName"] = textBox2.Text;
            newRow["FirstName"] = textBox3.Text;

            // imgFileName : 파일의 경로와 파일이름과 확장자

            FileStream fs = new FileStream(imgFileName, FileMode.Open, FileAccess.Read);
            byte[] imgArr = new byte[fs.Length];
            fs.Read(imgArr, 0, (int)fs.Length);
            newRow["photo"] = imgArr;

            ds.Tables["employees"].Rows.Add(newRow);


            // SqlCommand 객체를 DataAdapter에 연결된 테이블을 보고 자동 생성
            SqlCommandBuilder sb = new SqlCommandBuilder(da);



            try
            {
                da.Update(ds, "employees");
                ds.AcceptChanges();
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
                ds.RejectChanges();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int offSet;
            if (e.RowIndex < 9)
            {
                offSet = 78;
            }
            else
            {
                offSet = 0;
            }
            DataRow selectRow = ds.Tables["employees"].Rows[e.RowIndex];
            byte[] photoArr = new byte[0];
            photoArr = (byte[])selectRow["photo"];
            MemoryStream ms = new MemoryStream();
            ms.Write(photoArr, offSet, photoArr.Length - offSet);

            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
