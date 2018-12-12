using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class frmListViewEx2 : Form
    {
        public frmListViewEx2()
        {
            InitializeComponent();
        }

        private void frmListViewEx2_Load(object sender, EventArgs e)
        {
            // 현재 디렉토리에서 파일목록을 얻어오는 부분
            string currentDirectory = Environment.CurrentDirectory;
            this.Text = currentDirectory + "의 정보";
            DirectoryInfo di = new DirectoryInfo(currentDirectory);
            FileInfo[] fi = di.GetFiles();

            // 리스트 뷰를 업데이트 부분 : 업데이트 작업이 끝날때(EndUpdate()) 까지 리스트뷰의 갱신을 하지 않는 것을 보장
            listDir.BeginUpdate();
            listDir.View = View.Details;

            // 리스트뷰의 컬럼명 지정
            listDir.Columns.Add("파일명", 400, HorizontalAlignment.Left);
            listDir.Columns.Add("파일크기", 200, HorizontalAlignment.Right);
            listDir.Columns.Add("수정된 날짜", 600, HorizontalAlignment.Center);
            foreach (FileInfo item in fi)
            {
                ListViewItem lvi = new ListViewItem(item.Name); // 파일 이름
                double fileSize = Math.Truncate((double)(item.Length/1000));
                if (fileSize <1 )
                {
                    fileSize = 1;
                }
                lvi.SubItems.Add(fileSize + "KB");   // 파일 크기
                lvi.SubItems.Add(item.LastWriteTime.ToString());    // 마지막 수정날짜

                listDir.Items.Add(lvi);
            }
            listDir.EndUpdate();
        }
    }
}
