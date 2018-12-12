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
    public partial class frmListBoxQuiz : Form
    {
        public frmListBoxQuiz()
        {
            InitializeComponent();
        }

        private void lblMainSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selBySeoul = { "강남구", "금천구", "가산구" };
            string[] selByGyeonggi = { "안양", "안산", "시흥", "광명" };


            if (lblMainSelect.SelectedIndex == 0)
            {
                this.lblSubSelect.Items.Clear();
                this.lblSubSelect.Items.AddRange(selBySeoul);
            }
            else if (lblMainSelect.SelectedIndex == 1)
            {
                this.lblSubSelect.Items.Clear();
                this.lblSubSelect.Items.AddRange(selByGyeonggi);
            }
            else
            {
                this.lblSubSelect.Items.Clear();
            }
        }
        private void frmListBoxQuiz_Load(object sender, EventArgs e)
        {
            string[] mainArea = { "서울", "경기", "제주", "강원", "충청", "전라", "경상" };
            this.lblMainSelect.Items.AddRange(mainArea);


            ListBox mylistbox = new ListBox();
            this.Controls.Add(mylistbox);
            mylistbox.Text = "세부";
            mylistbox.Location = new Point(250, 250);
            mylistbox.Size = new Size(50, 50);
        }
    }
}
