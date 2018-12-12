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
    public partial class frmProgramInfo : Form
    {
        public frmProgramInfo()
        {
            InitializeComponent();

            this.lblProgramInfo.Text = "프로그램 명 : "+Application.ProductName;
            this.lblProgramInfo.Text += "\n버전 정보 : " + Application.ProductVersion;
            this.lblProgramInfo.Text += "\n제작국가 : " + Application.CurrentCulture;
            this.lblProgramInfo.Text += "\n기본데이터경로 : " + Application.CommonAppDataPath;
        }

        private void frmProgramInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 현재 폼만 닫음
            this.Close();
        }
    }
}
