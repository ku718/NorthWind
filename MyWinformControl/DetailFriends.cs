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
    public partial class DetailFriends : Form
    {
        private int friendNo;
        private string friendName;
        private string friendMobile;
        private string friendAddr;
        private string friendImage;

        public int FriendNo { get => friendNo; set => friendNo = value; }
        public string FriendName { get => friendName; set => friendName = value; }
        public string FriendMobile { get => friendMobile; set => friendMobile = value; }
        public string FriendAddr { get => friendAddr; set => friendAddr = value; }
        public string FriendImage { get => friendImage; set => friendImage = value; }

        public DetailFriends()
        {
            InitializeComponent();
        }
        

        private void DetailFriends_Load(object sender, EventArgs e)
        {
            this.lblNo.Text = "번호 : "+FriendNo.ToString();
            this.lblName.Text = "이름 : "+FriendName;
            this.lblMobile.Text = "전화번호 : "+FriendMobile;
            this.lblAddr.Text = "주소 : "+FriendAddr;

            //if (FriendNo == 2)
            //{
            //    this.picboxImage.ImageLocation = @"C:\Users\gd12\2.png";
            //}
            //else
            //{
            //    this.picboxImage.ImageLocation = @"C:\Users\gd12\5.jpg";
            //}


            this.picboxImage.ImageLocation = FriendImage;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            friendNo = 0;
            friendName = "";
            FriendMobile = "";
            friendAddr = "";
            friendImage = "";
            this.Close();
        }
    }
}

