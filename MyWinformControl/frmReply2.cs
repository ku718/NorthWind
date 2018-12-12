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
    public partial class frmReply2 : Form
    {
        private string name;
        private bool agree;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Agree
        {
            get { return agree; }
            set { agree = value; }
        }



        public frmReply2()
        {
            InitializeComponent();
        }

        public void ShowTitile(string title)
        {
            this.Text = title;
        }

        public frmReply2(string text) : this()
        {
            this.label1.Text += text;
        }

        private void frmReply2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.name);
            this.chkAgree.Checked = this.agree;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            frmDataTransferEx2 fdte = (frmDataTransferEx2)Owner;    //부모폼을 지정해야 한다.
            fdte.Msg = txtMessage.Text;
            this.Dispose(); // 자원해제
            this.Close();
        }
    }
}
