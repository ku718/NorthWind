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
    public partial class frmTabControlEx : Form
    {
        TabPage mytab;
        public frmTabControlEx()
        {
            InitializeComponent();

            // 동적으로 다 탭 이라는 이름의 탭을 추가하세요.
            mytab = new TabPage();  // 웹 페이지 객체 생성
            mytab.Text = "다 탭"; // 탭 페이지 탭 표시 이름
            this.tabControl1.TabPages.Add(mytab);   // 탭 컨트롤에 탭 페이지 추가

            // 동적으로 다 탭안에 텍스트 박스를 추가하세요
            TextBox tbox = new TextBox();
            tbox.Text = "동적으로 생성한 박스";
            tbox.Location = new Point(338, 171);
            tbox.Size = new Size(100, 21);
            tbox.KeyUp += Tbox_KeyUp;

            mytab.Controls.Add(tbox);   // 탭 페이지에 텍스트박스 추가
        }

        private void Tbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                MessageBox.Show("멜롱");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedIndex = 0;   // 둘다 사용가능
            this.tabControl1.SelectedTab = this.tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedIndex = 1;
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedIndex = 2;
            if (mytab != null)
            {
                this.tabControl1.SelectedTab = this.mytab;
            }
        }
    }
}
