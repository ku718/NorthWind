using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
           this.pictureBox1.ImageLocation = @"C:\Users\gd12\Dobby.jpg";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //DialogResult dlg = this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {   // 유저가 파일을 선택하고 열기 버튼을 클릭 했을 때
                this.pictureBox2.ImageLocation = this.openFileDialog1.FileName.ToString();
            }
        }
    }
}
