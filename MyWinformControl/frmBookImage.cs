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
    public partial class frmBookImage : Form
    {
        private string url;
        private BookInfo bookInfo;


        public frmBookImage()
        {
            InitializeComponent();
        }

        public frmBookImage(string url) : this()
        {
            this.url = url;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.ImageLocation = url;
        }

        public frmBookImage(BookInfo bookInfo) : this()
        {
            this.bookInfo = bookInfo;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = bookInfo.Image;

            this.Text = bookInfo.Title;
        }
    }
}
