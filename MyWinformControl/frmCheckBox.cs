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
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> hobby = new List<string>();
            if (this.chkCooking.Checked)
            {
                hobby.Add(this.chkCooking.Text);
                btnShow.Enabled = true;
            }
            if (this.chkGame.Checked)
            {
                hobby.Add(this.chkGame.Text);
            }
            if (this.chkMovie.Checked)
            {
                hobby.Add(this.chkMovie.Text);
            }
            if (this.chkReading.Checked)
            {
                hobby.Add(this.chkReading.Text);
            }

            if (hobby.Count == 0)
            {
                MessageBox.Show("취미를 하나라도 선택 하세요");
            }

            else
            {

                this.lblResult.Text = "당신의 취미는";
                for (int i = 0; i < hobby.Count; i++)
                {
                    if (i == hobby.Count - 1)
                    {
                        this.lblResult.Text += hobby[i];
                    }
                    else
                    {
                        this.lblResult.Text += hobby[i] + ", ";
                    }
                }
            }
        }

        private void frmCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
