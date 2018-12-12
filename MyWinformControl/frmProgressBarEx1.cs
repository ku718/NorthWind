using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class frmProgressBarEx1 : Form
    {
        public frmProgressBarEx1()
        {
            InitializeComponent();
        }

        private void frmProgressBarEx1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value += progressBar1.Step;
            }
            else
            {
                this.timer1.Enabled = false;
                //MessageBox.Show("작업완료");
            }
        }

        private void btnFildDown_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            Uri uri = new Uri("http://provide.ahnlab.com/v3lite/v30/download/V3Lite_Setup.exe");
            string fileName = @"C:\Users\GDC22\V3Lite_Setup.exe";

            // 파일 다운 완료 될때 발생하는 이벤트 핸들러
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            // 파일이 다운되는 도중 발생하는 이벤트 핸들러 -> 프로그래스바를 제어
            client.DownloadProgressChanged += Client_DownloadProgressChanged;


            client.DownloadFileAsync(uri, fileName);    // 실제 다운로드 받는 곳

            this.pictureBox1.Visible = true;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //this.proFileDown.Value  += e.ProgressPercentage;

            //this.proFileDown.Value = (int)((e.BytesReceived / e.TotalBytesToReceive) * 100);

            this.label2.Text = e.BytesReceived / 1024 + " KB" + "/" + e.TotalBytesToReceive / 1024 + " KB";

            double receive = (double)e.BytesReceived;   // 받은 파일 바이트 수
            double total = (double)e.TotalBytesToReceive;   // 받을 파일 바이트 수

            double percentage = receive / total * 100;  // 

            this.proFileDown.Value = (int)Math.Truncate(percentage);

        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("파일 다운로드 완료");
        }
    }
}
