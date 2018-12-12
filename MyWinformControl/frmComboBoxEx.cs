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
    public partial class frmComboBoxEx : Form
    {
        public frmComboBoxEx()
        {
            InitializeComponent();
        }

        private void cboJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboJob.SelectedIndex != -1)    // 선택된 항목이 있다면...
            {
                this.lblResult.Text = cboJob.SelectedItem.ToString();
            }
        }
    }
}
