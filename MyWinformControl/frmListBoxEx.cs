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
    public partial class frmListBoxEx : Form
    {
        public frmListBoxEx()
        {
            InitializeComponent();
        }

        private void lstHobby_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.lblReuslt.Text = this.lstHobby.Items[lstHobby.SelectedIndex].ToString();
            //this.lblReuslt.Text = this.lstHobby.SelectedItem.ToString();  // 단일 선택

            foreach (var item in lstHobby.SelectedItems)
            {
                this.lblReuslt.Text += item;
            }

        }

        private void frmListBoxEx_Load(object sender, EventArgs e)
        {
            //리스트박스에 동적으로 아이템 추가하기
            string[] bloodTypes = { "A형", "B형", "AB형", "O형" };

            this.lstBloodType.Items.AddRange(bloodTypes);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //예외 처리
            if (this.lstBloodType.SelectedIndex == -1)
            {
                MessageBox.Show("혈액형을 선택해 주세요!");
            }
            else
            {
                this.lblReuslt.Text = "당신의 혈액형은" + this.lstBloodType.SelectedItem.ToString();
            }
        }
    }
}
