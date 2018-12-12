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
    public partial class frmNumericUpdown : Form
    {
        public frmNumericUpdown()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.domainUpDown1.SelectedItem.ToString();
        }
    }
}
