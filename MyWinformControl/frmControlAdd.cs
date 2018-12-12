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
    public partial class frmControlAdd : Form
    {
        CheckBox checkBox = new CheckBox();

        public frmControlAdd()
        {
            InitializeComponent();
        }

        private void chkButton_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if (chkButton.Checked)
            {
                this.btnButton.Visible = true;
            }
            else if (!chkButton.Checked)
            {
                this.btnButton.Visible = false;
            }
        }

        private void chkButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkButton2.Checked)
            {
                this.btnButton2.Enabled = true;
            }
            else if (!chkButton2.Checked)
            {
                this.btnButton2.Enabled = false;
            }
        }

        private void frmControlAdd_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            Button myButton = new Button(); // 버튼 객체 생성

            // 필요한 프로퍼티 설정
            myButton.Text = "동적으로 생성한 버튼1";
            myButton.Location = new Point(150, 200);
            myButton.Size = new Size(150, 50);

            this.Controls.Add(myButton);    // 폼의 컨트롤 컬렉션에 동적으로 생성한 객체를 등록


            //myButton.Click += MyButton_Click;   //  동적으로 생성한 버튼에 클릭 이벤트 핸들러 부여
            myButton.Click += new EventHandler(MyButton_Click);     // 델리게이트  new EventHandler는 생략이 가능한 부분




            //myCheckBox 라는 이름의 체크박스를 동적으로 생성하고, Text = "동적 생성"
            //Checked Change라는 이벤트를 부여해서 체크박스가 체크가 되면 메세지 박스를 띄우도록 해라

            checkBox.Text = "동적 생성";
            checkBox.Location = new Point(200,250);
            checkBox.Size = new Size(150, 50);

            this.Controls.Add(checkBox);

            checkBox.CheckedChanged += CheckBox_Click;

            foreach (var item in this.Controls)
            {
                this.lblControlList.Text += item.ToString();
            }

            if (Controls.Contains(checkBox))
            {
                MessageBox.Show("체크박스가 있습니다");
            }
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("동적으로 생성한 체크박스");
            if (checkBox.Checked)
            {
                this.Controls.Clear();  // 폼에 있는 모든 컨트롤들을 지움
            }
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("동적으로 생성한 버튼이 클릭도 되네!");
        }
    }
}
