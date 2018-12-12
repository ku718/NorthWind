using Newtonsoft.Json.Linq;
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
using System.Web;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class frmJsonQuiz2 : Form
    {
        private List<ShoppingInfo> lst = new List<ShoppingInfo>();
        string json;

        private int pgSize = 20;    // 1페이지당 보여줄 데이터의 개수
        private int totalDateCnt = 0;   // 토탈 데이터 수
        private int currentPageIndex = 0;   // 현재 페이지 번호
        private int totalPageNum = 0;   // 전체 페이지 수

        public frmJsonQuiz2()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dgvShopping.DataSource = null;
            lst.Clear();
            string hexStr = HttpUtility.UrlEncode(txtSearch.Text);
            var serverUrl = "https://openapi.naver.com/v1/search/shop.json" + "?query=" + hexStr + "&display=" + pgSize + "&start=" + ((currentPageIndex * pgSize) + 1);
            string clientId = "BsqZ71pvX5sSf2H6Vbr_";
            string clientSecret = "C6DB5FQBaO";

            var req = (HttpWebRequest)WebRequest.Create(serverUrl);
            req.Headers.Add("X-Naver-CLIENT-ID", clientId);
            req.Headers.Add("X-Naver-CLIENT-SECRET", clientSecret);
            var res = (HttpWebResponse)req.GetResponse();

            var statusCode = res.StatusCode.ToString();

            if (statusCode == "OK")
            {
                var stream = res.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                //json = txtSearch.Text;
                this.textBox1.Text = sr.ReadToEnd().Replace("<b>", "").Replace("</b>", "");
                //json = sr.ReadToEnd();

                json = this.textBox1.Text;
            }
            else
            {
                MessageBox.Show("에러발생 : " + statusCode);
            }


            var jObj = JObject.Parse(json);
            var itemsArr = JArray.Parse(jObj["items"].ToString());

            foreach (JObject item in itemsArr)
            {
                string title = item["title"].ToString();
                string link = item["link"].ToString();
                string image = item["image"].ToString();
                int lprice = Int32.Parse(item["lprice"].ToString());
                int hprice = Int32.Parse(item["hprice"].ToString());
                string mallName = item["mallName"].ToString();
                double productId;
                try
                {
                    productId = Int32.Parse(item["producId"].ToString());

                }
                catch (NullReferenceException)
                {
                    productId = 0;
                }
                int productType = Int32.Parse(item["productType"].ToString());

                ShoppingInfo si = new ShoppingInfo
                {
                    Title = title,
                    Link = link,
                    Image = image,
                    Lprice = lprice,
                    Hprice = hprice,
                    MallName = mallName,
                    ProductId = productId,
                    ProductType = productType
                };
                lst.Add(si);
            }
            this.dgvShopping.DataSource = lst;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }
    }
}
