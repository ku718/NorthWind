using Newtonsoft.Json;
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
    public partial class FrmBookApi : Form
    {

        private int pgSize = 20;    // 1페이지당 보여줄 데이터의 개수
        private int totalDateCnt = 0;   // 토탈 데이터 수
        private int currentPageIndex = 0;   // 현재 페이지 번호
        private int totalPageNum = 0;   // 전체 페이지 수


        private List<BookInfo> lst;
        public FrmBookApi()
        {
            InitializeComponent();
        }
        private void FrmBookApi_Load(object sender, EventArgs e)
        {
            lst = new List<BookInfo>();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string hexStr = HttpUtility.UrlEncode(txtSearch.Text); //이게 더 편함
            string hexStr = ConvertUtf8(txtSearch.Text);  // 위에것을 쓰면 메서드를 만들지 않고 바로 할 수 있음
            var serverUrl = "https://openapi.naver.com/v1/search/book.json" + "?query=" + hexStr + "&display=" + pgSize + "&start=" + ((currentPageIndex * pgSize) +1);
            //var jsonObject = JsonConvert.DeserializeObject(GetJson(serverUrl));


            DisplayBooks(serverUrl);
        }

        private void DisplayBooks(string serverUrl)
        {
            // json포맷을 JObject 타입으로 파싱 
            // 원하는 데이터가 items라는 객체배열에 있어서 접근하기 위해
            var jObj = JObject.Parse(GetJson(serverUrl));
            // 만들어진 JObject타입에서 원하는 items 멤버에 접근하여 배열로 가져옴
            // JArray : JObject가 들어있는 배열
            totalDateCnt = Int32.Parse(jObj["total"].ToString());
            totalPageNum = totalDateCnt / pgSize;
            if (totalDateCnt % pgSize != 0) // 나누어 떨이지지 않으면
            {
                totalPageNum += 1;  // 1페이지가 더 필요하다.
            }

            lblPageInfo.Text = String.Format("({0} / {1})", currentPageIndex+1, totalPageNum);

            var itemsArr = JArray.Parse(jObj["items"].ToString());

            foreach (JObject item in itemsArr)
            {
                string title = item["title"].ToString();
                string link = item["link"].ToString();
                string image = item["image"].ToString();
                string author = item["author"].ToString();
                int price = (item["price"].ToString() == "") ? 0 : Int32.Parse(item["price"].ToString());
                int discount = (item["discount"].ToString() == "") ? 0 : Int32.Parse(item["discount"].ToString());
                string publisher = item["publisher"].ToString();
                DateTime pubDate;
                try
                {
                     pubDate = new DateTime(Int32.Parse(item["pubdate"].ToString().Substring(0, 4)), Int32.Parse(item["pubdate"].ToString().Substring(4, 2)), Int32.Parse(item["pubdate"].ToString().Substring(6, 2)));
                }
                catch (Exception)
                {
                    pubDate = new DateTime();   
                }
                string isbn = item["isbn"].ToString();
                string description = item["description"].ToString();

                BookInfo book = new BookInfo
                {
                    Title = title,
                    Link = link,
                    Image = image,
                    Author = author,
                    Price = price,
                    Discount = discount,
                    Publisher = publisher,
                    PubDate = pubDate,
                    Isbn = isbn,
                    Description = description
                };
                lst.Add(book);
            }
            this.dGVBooks.DataSource = lst;
        }

        private string GetJson(string serverUrl)
        {
            string json = String.Empty;
            // api서버에 인증하기 위해 사용자 정보를  HTTP헤더에 추가
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
                this.txtJson.Text = sr.ReadToEnd().Replace("<b>", "").Replace("</b>", "");
                json = txtJson.Text;
            }
            else
            {
                MessageBox.Show("에러발생 : " + statusCode);
            }
            return json;
        }

        /// <summary>
        /// 문자열을 UTF-8로 변환
        /// </summary>
        /// <param name="text">대상 문자열</param>
        /// <returns>변환된 문자열</returns>
        private string ConvertUtf8(string text)
        {
            // 텍스트박스의 텍스트 값을 유니코드 (UTF-16)으로 변환
            byte[] txtBytes = Encoding.Unicode.GetBytes(txtSearch.Text);
            // 유니코드의 값을 UTF-8로 변환
            byte[] txtUtf8Byte = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, txtBytes);

            string hexStr = String.Empty;
            // 10진수를 16진수로 변환
            for (int i = 0; i < txtUtf8Byte.Length; i++)
            {
                // txtUtf8Byte[i]의 값을 16진수로 변환
                var strtex = Convert.ToString((int)txtUtf8Byte[i], 16);
                hexStr += "%" + strtex;
            }
            return hexStr;
        }

        private void dGVBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string url = dGVBooks.CurrentCell.Value.ToString();
                // MessageBox.Show(url);
                try
                {
                    Uri uri = new Uri(url); // url 객체로 만들어 봐서 url 주소인지 아닌지 판별
                    System.Diagnostics.Process.Start(url);
                }
                catch (UriFormatException)
                {
                    // 예외가 발생하면 url 주소가 아니다
                    MessageBox.Show("웹 페이지를 열 수 없습니다");
                }
            }
            else if (e.ColumnIndex == 2)
            {
                //string url = dGVBooks.CurrentCell.Value.ToString();
                //try
                //{
                //    Uri uri = new Uri(url);
                //    frmBookImage fbi = new frmBookImage(url);
                //    fbi.ShowDialog();
                //}
                //catch (Exception)
                //{
                //    // 예외가 발생하면 url주소가 아니다
                //    MessageBox.Show("이미지를 열 수 없습니다");
                //}


                frmBookImage fbi = new frmBookImage(lst[e.RowIndex]);
                fbi.ShowDialog();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dGVBooks.DataSource = null;
                lst.Sort(new BookCompare());
                dGVBooks.DataSource = lst;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            dGVBooks.DataSource = null; //그리드뷰 초기화
            lst.Clear();    //컬렉션 초기화

            if ((currentPageIndex + 1) <= totalPageNum)
            {
                currentPageIndex++;
            }
            else
            {
                MessageBox.Show("마지막 페이지");
                return;
            }

            btnSearch_Click(null, null);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            dGVBooks.DataSource = null; // 그리드뷰 초기화
            lst.Clear();    // 컬렉션 초기화

            if (currentPageIndex >= 1)
            {
                currentPageIndex--;
            }
            else
            {
                MessageBox.Show("첫 페이지 입니다");
                return;
            }

            btnSearch_Click(null, null);
        }
    }
}
