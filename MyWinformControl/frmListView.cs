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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            lstCityInfo.View = View.LargeIcon;    // 리스트 뷰의 보기모드를 큰아이콘으로...
            lstCityInfo.Columns.Add("도시 구분",200,HorizontalAlignment.Center);
            lstCityInfo.Columns.Add("인구 밀도", 200, HorizontalAlignment.Center);
            lstCityInfo.Columns.Add("면적(km)", 200, HorizontalAlignment.Center);

            //lstCityInfo.Items.Add(new ListViewItem(new string[] { "서울", "17,025", "605" }));
            //DB, XML, json, file 에서 데이터를 읽어오는 부분

            CityInfo[] cities = {
                new CityInfo("서울",17025,605),
                new CityInfo("동경",13650,622),
                new CityInfo("북경",6996,236)
            };



            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(256, 256);
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            //리스트뷰 사용될 수 있는 이미지 (jpg,png,ico)
            Image img1 = Image.FromFile(@"C:\Users\gd12\cityscape.png");
            imgList.Images.Add("city", img1);   // 이미지를 이미지리스트에 등록
            lstCityInfo.LargeImageList = imgList;   // 리스트뷰에 이미지리스트를 큰 아이콘으로 추가

            // 리스트뷰에 동적으로 내용 추가 [동적 바인딩]
            foreach (var item in cities)
            {
                //lstCityInfo.Items.Add(new ListViewItem(new string[] { "서울", "17,025", "605" }));
                var li = new ListViewItem(new string[] { item.Cityname, item.Popular.ToString(), item.Area.ToString() });

                li.ImageKey = "City";

                lstCityInfo.Items.Add(li);

            }
            
        }

        private void rdoLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLargeIcon.Checked)
            {
                lstCityInfo.View = View.LargeIcon;
            }
        }

        private void rdoDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDetail.Checked)
            {
                lstCityInfo.View = View.Details;
            }
        }

        
        private void lstCityInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstCityInfo.SelectedItems.Count > 0)    // 아이템이 선택되지 않았을 경우 (선택 취소) - 예외처리
            {
                MessageBox.Show("도시 이름 : " + lstCityInfo.SelectedItems[0].SubItems[0].Text
                    + ", 인구 : " + lstCityInfo.SelectedItems[0].SubItems[1].Text
                    + ", 면적 : " + lstCityInfo.SelectedItems[0].SubItems[2].Text);
            }
        }
    }
}
