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
    public partial class frmDataTransferEx2 : Form
    {
        private string msg;
        private bool agree;
        public frmDataTransferEx2()
        {
            InitializeComponent();
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmReply2 fr2= new frmReply2(this.txtTransfer.Text);    // 생성자를 통한 데이터 전달
            fr2.ShowTitile("답변이 전송되나요");    // 멤버 메서드를 통한 데이터 전달
            fr2.Name = "홍길동";
            fr2.Owner = this;   // fr2(자식폼)의 부모가 현재 폼이다.
            fr2.Agree = this.agree;
            fr2.ShowDialog();

            this.lblParent.Text = msg;

        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAgree.Checked)
            {
                this.agree = true;
            }
            else
            {
                this.agree = false;
            }
        }
    }
}
