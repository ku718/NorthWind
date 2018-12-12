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
    public partial class frmDataTransferEx : Form
    {
        public frmDataTransferEx()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmReply fr = new frmReply();
            fr.Owner = this;
            DialogResult dr = fr.ShowDialog();
            //MessageBox.Show(dr.ToString());
            if (dr==DialogResult.Yes)
            {
                MessageBox.Show("그럼 일해라...");
            }
            else
            {
                MessageBox.Show("밥 먹자");
            }
        }
    }
}
