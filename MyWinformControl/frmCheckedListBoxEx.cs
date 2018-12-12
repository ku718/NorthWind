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
    public partial class frmCheckedListBoxEx : Form
    {
        public frmCheckedListBoxEx()
        {
            InitializeComponent();
        }

        private void frmCheckedListBoxEx_Load(object sender, EventArgs e)
        {
            string[] hobby = { "등산", "낚시", "여행", "축구", "게임" };
            this.chklistHobby.Items.AddRange(hobby);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (var item in chklistHobby.CheckedItems)
            {
                this.lblResult.Text += item.ToString()+",";
            }
        }
    }
}
