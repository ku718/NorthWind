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
    public partial class frmReply : Form
    {
        private DialogResult yesOrNo;
        
        public DialogResult YesOrNo
        {
            get { return yesOrNo; }
            set { yesOrNo = value; }
        }

        public frmReply()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            yesOrNo = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            yesOrNo = DialogResult.No;
        }
    }
}
