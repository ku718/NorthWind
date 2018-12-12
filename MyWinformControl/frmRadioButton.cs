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
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string gender = String.Empty;
            string hobby = String.Empty;
            if (this.rdomale.Checked)
            {
                gender = this.rdomale.Text;
            }
            else
            {
                gender =this.rdoFemale.Text;
            }

            if (this.rdoSoccer.Checked)
            {
                hobby = this.rdoSoccer.Text;
            }
            else if (this.rdoPlay.Checked)
            {
                hobby = this.rdoPlay.Text;
            }
            else
            {
                hobby = this.rdoClimb.Text;
            }

            this.lblResult.Text = "당신의 성별은 " + gender + "입니다";
            this.lblResult.Text += "\n당신의 동아리는 " + hobby + "입니다";
        }
    }
}
