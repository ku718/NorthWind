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
using HtmlAgilityPack;


namespace MyWinformControl
{
    public partial class frmMiniWebBrowser : Form
    {

        private Uri uri;

        public frmMiniWebBrowser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 뒤로, 앞으로, 새로고침의 기능을 통합한 이벤트 핸들러
        /// 어떤 버튼에서 클릭 이벤트가 발생했는지를 판단하여
        /// 뒤로, 앞으로, 새로고침의 기능을 수행함.
        /// </summary>
        /// <param name="sender">어떤 컨트롤에서 이벤트가 발생했는지를 담고 있는 매개변수</param>
        /// <param name="e"></param>
        private void MyBtnClick(object sender, EventArgs e)
        {
            //MessageBox.Show(((ToolStripButton)sender).Name+"이 클릭됨");

            //var controlName = ((ToolStripButton)sender).Name; // 명시적 캐스팅
            var controlName = (sender as ToolStripButton).Name; // 캐스팅

            if (controlName == "btnPrev")
            {
                // 뒤로
                this.myWeb.GoBack();
            }
            else if (controlName == "btnNext")
            {
                // 앞으로
                this.myWeb.GoForward();
            }
            else if (controlName == "btnReload")
            {
                // 새로고침
                this.myWeb.Refresh();
            }

        }

        private void frmMiniWebBrowser_Load(object sender, EventArgs e)
        {
            this.uri = new Uri("https://www.google.co.kr/maps/place/%EA%B2%BD%EC%83%81%EB%82%A8%EB%8F%84+%EA%B1%B0%EC%A0%9C%EC%8B%9C+%EC%97%B0%EC%B4%88%EB%A9%B4+%EC%97%B0%EC%82%AC%EB%A6%AC+93/@34.9071269,128.6499124,17z/data=!3m1!4b1!4m5!3m4!1s0x356ed2cabb0a05e7:0x329a9252008c599f!8m2!3d34.9071225!4d128.6521011?hl=ko");
            this.myWeb.Url = uri;
            this.txtUrl.Text = "https://store.naver.com/restaurants/detail?id=34595562";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtUrl.Text))
            {
                if (!this.txtUrl.Text.Contains("http://"))
                {
                    this.txtUrl.Text = "http://" + txtUrl.Text;
                }
                try
                {
                    this.uri = new Uri(this.txtUrl.Text);
                    this.myWeb.Url = uri;
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("잘못된 웹 주소입니다, 확인 후 다시 입력해 주세요");
                    this.txtUrl.SelectAll();
                }
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    // Enter 키가 눌려졌을 때
            {
                btnGo_Click(null, null);
            }
        }

        private void myWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 웹 문서를 가져오기 위해 request 객체를 생성
            HttpWebRequest request = WebRequest.Create(this.uri) as HttpWebRequest;
            // 위의 request에 대한 response객체를 생성
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            // 웹 문서를 가져오기위한 response객체에 대한 스트림 객체
            Stream stream = response.GetResponseStream();
            // 웹 문서를 읽기위한 StreamReader
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string webString = reader.ReadToEnd();  // 스트림으로부터 html 문서를 읽어옴

            this.txtWebSource.Text = webString; // 스트림으로 읽어온 웹 문서 소스를 텍스트박스에 출력

            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(webString);    // 웹문서 문자열을 HtmlDocument객체로 생성

            DoHtmlParsing(htmlDoc);
        }

        private void DoHtmlParsing(HtmlAgilityPack.HtmlDocument htmlDoc)
        {
            //string name = htmlDoc.DocumentNode.SelectSingleNode("//meta").GetAttributeValue("content", "");
            //this.lblTitle.Text = name;

            ////string desc = htmlDoc.DocumentNode.SelectSingleNode("//meta").NextSibling.GetAttributeValue("content", ""); // 출력이 안되넹?

            //this.lblDesc.Text = htmlDoc.DocumentNode.SelectNodes("//meta")[1].GetAttributeValue("content", "");

            string title =  htmlDoc.DocumentNode.SelectNodes("//meta")[4].GetAttributeValue("content", "");
            this.lblTitle.Text = title;

            string addr = htmlDoc.DocumentNode.SelectNodes("//meta")[5].GetAttributeValue("content","");
            this.lblAddr.Text = addr;

            
        }
    }
}
