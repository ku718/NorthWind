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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.statusWatch.Text = DateTime.Now.ToLongTimeString();
            this.watchTimer.Enabled = true;
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // 어플리케이션 종료
            Application.Exit();
        }

        private void mnuProgramInfo_Click(object sender, EventArgs e)
        {
            frmProgramInfo fpi = new frmProgramInfo();  // 폼 클래스의 객체 생성하고, 
            //fpi.MdiParent = this;     // 모달폼은 MDI 가 되지 않음
            fpi.ShowDialog();   // 모달 폼으로 띄우기
        }

        private void 버튼라벨텍스트박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fblt fblt = new fblt();   // 폼 클래스 객체 생성
            fblt.MdiParent = this;  // MDI 컨테이너가 현재 클래스 임을 명시
            fblt.Show();    // 모달리스 폼으로 띄우기
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLink fll = new frmLink();
            fll.MdiParent = this;
            fll.Show();
        }

        private void 라디오버튼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadioButton frb = new frmRadioButton();
            frb.MdiParent = this;
            frb.Show();
        }

        private void linklabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLink fll = new frmLink();
            fll.MdiParent = this;
            fll.Show();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckBox fcb = new frmCheckBox();
            fcb.MdiParent = this;
            fcb.Show();
        }

        private void 동적컨트롤생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControlAdd fca = new frmControlAdd();
            fca.MdiParent = this;
            fca.Show();
        }

        private void 리스트박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxEx flbe = new frmListBoxEx();
            flbe.MdiParent = this;
            flbe.Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuExit_Click(null, null);
        }

        private void 리스트박스퀴즈1112ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxQuiz flbq = new frmListBoxQuiz();
            flbq.MdiParent = this;
            flbq.Show();
        }

        private void 체크드리스트박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckedListBoxEx fclb = new frmCheckedListBoxEx();
            fclb.MdiParent = this;
            fclb.Show();
        }

        private void 콤보박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComboBoxEx fcbe = new frmComboBoxEx();
            fcbe.MdiParent = this;
            fcbe.Show();
        }

        private void 데이트타임피커ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateTimePicker fdtp = new frmDateTimePicker();
            fdtp.MdiParent = this;
            fdtp.Show();
        }

        private void 숫자카운터ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumericUpdown fnud = new frmNumericUpdown();
            fnud.MdiParent = this;
            fnud.Show();
        }

        private void 픽쳐박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPictureBox fpb = new frmPictureBox();
            fpb.MdiParent = this;
            fpb.Show();
        }

        private void 폼간데이터전송ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataTransferEx fdtfe = new frmDataTransferEx();
            fdtfe.MdiParent = this;
            fdtfe.Show();
        }

        private void 폼간데이터전송나머지타입의데이터ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataTransferEx2 fetfe2 = new frmDataTransferEx2();
            fetfe2.MdiParent = this;
            fetfe2.Show();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListView flv = new frmListView();
            flv.MdiParent = this;
            flv.Show();
        }

        private void imageListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPic fil = new myPic();
            fil.MdiParent = this;
            fil.Show();
        }

        private void listView2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListViewEx2 flv2 = new frmListViewEx2();
            flv2.MdiParent = this;
            flv2.Show();
        }

        private void mSSQLGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDBGridView fdgv = new frmDBGridView();
            fdgv.MdiParent = this;
            fdgv.Show();
        }

        private void xMLEX1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXmlEx1 fxe = new FrmXmlEx1();
            fxe.MdiParent = this;
            fxe.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooksEx1 fbe = new frmBooksEx1();
            fbe.MdiParent = this;
            fbe.Show();
        }

        private void miniWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMiniWebBrowser fmwb = new frmMiniWebBrowser();
            fmwb.MdiParent = this;
            fmwb.Show();
        }

        private void dBXML저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatabaseXML fdbx = new FrmDatabaseXML();
            fdbx.MdiParent = this;
            fdbx.Show();
        }

        private void watchTimer_Tick(object sender, EventArgs e)
        {
            this.statusWatch.Text = DateTime.Now.ToLongTimeString();
        }

        private void miniNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotePad fnp = new FrmNotePad();
            fnp.MdiParent = this;
            fnp.Show();
        }

        private void 탭컨트롤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabControlEx ftxe = new frmTabControlEx();
            ftxe.MdiParent = this;
            ftxe.Show();
        }

        private void 트리노드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTreeView ftv = new frmTreeView();
            ftv.MdiParent = this;
            ftv.Show();
        }

        private void progressBarEx1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgressBarEx1 fpb = new frmProgressBarEx1();
            fpb.MdiParent = this;
            fpb.Show();
        }

        private void 차트1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChartEx1 fhe1 = new frmChartEx1();
            fhe1.MdiParent = this;
            fhe1.Show();
        }

        private void 차트퀴즈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChartQuiz fcq = new frmChartQuiz();
            fcq.MdiParent = this;
            fcq.Show();
        }

        private void 차트퀴즈2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChartQuiz2 fcq2 = new frmChartQuiz2();
            fcq2.MdiParent = this;
            fcq2.Show();

            //Data Source=DESKTOP-LNQ5TIB;User ID=northwind_kun;Password=***********
        }

        private void sqlDB연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSqlConnect fsc = new frmSqlConnect();
            fsc.MdiParent = this;
            fsc.Show();
        }

        private void serializationDeSerializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJsonEx1 jse1 = new FrmJsonEx1();
            jse1.MdiParent = this;
            jse1.Show();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJsonEx2 jse2 = new FrmJsonEx2();
            jse2.MdiParent = this;
            jse2.Show();
        }

        private void jsonQuiz1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJsonQuiz1 jsq1 = new FrmJsonQuiz1();
            jsq1.MdiParent = this;
            jsq1.Show();
        }

        private void apiExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBookApi fba = new FrmBookApi();
            fba.MdiParent = this;
            fba.Show();
        }

        private void jsonQuiz2ParsingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJsonQuiz2 jsq2 = new frmJsonQuiz2();
            jsq2.MdiParent = this;
            jsq2.Show();
        }

        private void dataAdapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSqlDataAdapterEx1 sqdae = new FrmSqlDataAdapterEx1();
            sqdae.MdiParent = this;
            sqdae.Show();
        }

        private void bindingNavigatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBindingNavigatorEx1 fbn = new FrmBindingNavigatorEx1();
            fbn.MdiParent = this;
            fbn.Show();
        }

        private void bindingNavigator2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBindingNavigator2 fbn2 = new FrmBindingNavigator2();
            fbn2.MdiParent = this;
            fbn2.Show();
        }

        private void bindingPracticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBindingPractice fbp = new FrmBindingPractice();
            fbp.MdiParent = this;
            fbp.Show();
        }

        private void dataRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataRelationEx1 fdre = new FrmDataRelationEx1();
            fdre.MdiParent = this;
            fdre.Show();
        }

        private void dataSetCRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataSetCRUD fdsc = new FrmDataSetCRUD();
            fdsc.MdiParent = this;
            fdsc.Show();
        }

        private void imageToPictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImageToPictureBox fitpb = new FrmImageToPictureBox();
            fitpb.MdiParent = this;
            fitpb.Show();
        }

        private void northwindQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNorthwind fnw = new FrmNorthwind();
            fnw.MdiParent = this;
            fnw.Show();
        }
    }
}
