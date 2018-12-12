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
    public partial class FrmNotePad : Form
    {
        private FrmSearch frmSearch;
        private string fileName;
        //FrmSearch fs = new FrmSearch();
        private string findWord;
        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void FrmNotePad_Load(object sender, EventArgs e)
        {
            myToolTip.SetToolTip(this.btnFileOpen, "파일을 읽으려면 버튼을 클릭하세요");
            myToolTip.SetToolTip(this.btnSave, "파일을 저장하려면 이 버튼을 클릭하세요");
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if (this.dlgFileOpen.ShowDialog() != DialogResult.Cancel)
            {
                fileName = dlgFileOpen.FileName; //파일을 읽기 위해 경로 + 파일명
                //this.Text = fileName + " 미니 메모장";   // 제목을 파일의 경로와 파일명으로 바꿈
                this.Text = dlgFileOpen.SafeFileName;   // 경로는 빼고 파일 이름만 제목으로 바꿈

                string readStr = "";
                FileInfo readFile = new FileInfo(fileName);
                if (readFile.Length > 0)    // 파일이 정상이라면
                {
                    StreamReader sr = new StreamReader(fileName, Encoding.Default);
                    readStr = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("파일을 읽을 수 없습니다.");
                }
                this.txtNotePad.Text = readStr;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.txtNotePad.Font = this.fontDialog1.Font;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dlgFileSave.ShowDialog() != DialogResult.Cancel)
            {
                string fileName = dlgFileSave.FileName; // 파일 저장을 위해 경로명 + 파일명 가져오기

                StreamWriter sw = new StreamWriter(fileName);
                // 버퍼메모리에 txtNotePad.Text 의 내용을 복사
                sw.Write(this.txtNotePad.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void FrmNotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("프로그램을 종료 하시겠습니까?", "미니 메모장", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //fs.Owner = this;
            //fs.ReadFile = fileName;
            //fs.Show();
            if (!(frmSearch == null || !frmSearch.Visible))
            {
                frmSearch.Focus();  // 폼 활성화
                return;
            }

            frmSearch = new FrmSearch();

            if (this.txtNotePad.SelectionLength == 0)
            {   // 찾을 단어가 선택되지 않았을 때
                this.frmSearch.txtSearchWord.Text = this.findWord;
            }
            else
            {
                this.frmSearch.txtSearchWord.Text = this.txtNotePad.SelectedText;
            }

            frmSearch.Show();
            // frmSearch에 있는 다음 찾기 버튼에 대한 이벤트 핸들러를 만듬
            frmSearch.btnNextSearch.Click += SearchStart;
        }

        private void SearchStart(object sender, EventArgs e)
        {
            var updown = -1;
            var bodyStr = this.txtNotePad.Text; // 찾을 대상 텍스트를 변수에 저장
            findWord = frmSearch.txtSearchWord.Text; // 찾을 문자열

            if (!frmSearch.chkCase.Checked)  // 대소문자 구분이라면
            {
                bodyStr = bodyStr.ToUpper();  // 찾을 대상 문자열을 대문자로
                findWord = findWord.ToUpper();  // 찾을 단어도 대문자로
            }

            if (frmSearch.rdoUp.Checked)    // 찾을 방향 - 위로
            {
                if (this.txtNotePad.SelectionStart != 0)
                {
                    // 찾을 방향 - 위로
                    // 현재 커서 위치 바로 앞부터 거꾸로 찾기 시작
                    updown = bodyStr.LastIndexOf(findWord, this.txtNotePad.SelectionStart - 1);
                }
            }
            else if(frmSearch.rdoDown.Checked)
            {
                //  찾을 방향 - 아래로
                //  선택된 단어가 있다면 그 단어 다음 문자부터 찾기 시작
                //  없다면 현재 커서의 위치 다음부터 찾기 시작
                updown = bodyStr.IndexOf(findWord, this.txtNotePad.SelectionStart + this.txtNotePad.SelectionLength);
            }
            if (updown == -1)
            {
                MessageBox.Show("더 이상 찾는 문자열이 없습니다");
                return;
            }

            this.txtNotePad.Select(updown, findWord.Length);    // 찾은 단어를 선택(드래그 되어있음)
            findWord = frmSearch.txtSearchWord.Text;
            this.txtNotePad.Focus();
            this.txtNotePad.ScrollToCaret();    // 현재 커서가 있는 위치까지 스크롤 바를 내림
        }
    }
}