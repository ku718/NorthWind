using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyWinformControl
{
    public partial class fblt : Form
    {
        public fblt()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.tbxName.Text = "";
            this.tbxPhone.Text = "";
            this.tbxAdds.Text = "";
            this.tbxName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = "[ㄱ-ㅎ|ㅏ-ㅣ|가-힣]";   // 한글인지
            string mobilePattern = @"^\d{3}-\d{3,4}-\d{4}$";
            string emailPattern = @"^[0-9a-zA-Z]([-_.]?[0-9a-zA-Z])*@[0-9a-zA-Z]([-_.]?[0-9a-zA-Z])*.[a-zA-Z]{2,3}$";
            


            if (String.IsNullOrEmpty(this.tbxName.Text))
            {
                MessageBox.Show("이름은 반드시 가입하셔야 합니다!", "마이윈폼", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(this.tbxName.Text, pattern))
            {
                MessageBox.Show("이름은 한글로만 입력해주세요");
                this.tbxName.Focus();
            }

            else if (!Regex.IsMatch(this.tbxPhone.Text,mobilePattern))
            {
                MessageBox.Show("전화번호 확인하세요");
                this.tbxPhone.Focus();
            }
            else if (!Regex.IsMatch(this.tbxEmail.Text,emailPattern))
            {
                MessageBox.Show("이메일을 다시확인하세요");
                this.tbxEmail.Focus();
            }
            lblOutput.Text = "이름 : " + this.tbxName.Text + "\n전화번호 :" + this.tbxPhone.Text + "\n이메일 :" + tbxEmail.Text + "\n주소 :" + tbxAdds.Text;
        }
    }
}
