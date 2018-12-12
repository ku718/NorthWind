using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class myPic : Form
    {
        public myPic()
        {
            InitializeComponent();
        }

        private void frmImageList_Load(object sender, EventArgs e)
        {
            imgList.ImageSize = new Size(256, 256); 
            imgList.ColorDepth = ColorDepth.Depth32Bit; // 이미지의 해상도
            
            // 파일로부터 이미지, 비트맵 객체 생성 후 이미지 리스트에 추가
            Image img1 = Image.FromFile(@"C:\Users\gd12\Dobby.jpg");
            this.imgList.Images.Add("Dobby",img1);

            Bitmap bit1 = new Bitmap(@"C:\Users\gd12\Pica.png");
            this.imgList.Images.Add("Pica", bit1);

            Image img2 = Image.FromFile(@"C:\Users\gd12\Tele.jpeg");
            this.imgList.Images.Add("Teletoby", img2);


            //웹으로부터 이미지, 비트맵 객체 생성 후 이미지 리스트 추가
            //자원이 위치한 유일한 주소 = URI
            //웹과 통신하는 방식 : request객체와 response객체를 만든후 스트림을 생성
            //웹은 request(요청) 객체에 대해 스트림으로 응답(response)을 해준다.

            Uri uri = new Uri("https://vignette.wikia.nocookie.net/pokemon/images/1/11/%EC%A7%80%EC%9A%B0%EC%9D%98_%ED%94%BC%EC%B9%B4%EC%B8%84.png/revision/latest?cb=20171008074246&path-prefix=ko");

            WebRequest request = WebRequest.Create(uri); // request 객체 만듬
            // 현재 request에 대한 response객체 생성
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Image webImg = Image.FromStream(stream);
            this.imgList.Images.Add("그림", webImg);



            // 이미지 리스트에 이미지가 잘 등록되어있는지 확인

            //foreach (var item in imgList.Images)
            //{
            //    MessageBox.Show(item.ToString());
            //}



            picBoxMyImg.Image = imgList.Images[0];

            this.trackBar.Maximum = imgList.Images.Count-1;   // 트랙바의 맥시멈을 이미지수

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            picBoxMyImg.Image = imgList.Images[trackBar.Value];
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int imgNo = 0;
            // 2초마다 자동으로 이벤트 핸들러가 호출
            if (trackBar.Value != imgList.Images.Count-1)
            {
                trackBar.Value++;
            }
            else
            {
                trackBar.Value=0;
            }
            picBoxMyImg.Image = imgList.Images[trackBar.Value];

        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            //체크박스가 체크가 되었을때만 타이머의 틱 이벤트가 발생되도록
            if (chkAuto.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
