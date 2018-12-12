using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyWinformControl
{
    public partial class frmChartEx1 : Form
    {
        public frmChartEx1()
        {
            InitializeComponent();
        }

        List<ChartStudent> students;

        private void frmChartEx1_Load(object sender, EventArgs e)
        {
            //차트 종류 변경
            myChart.Series[0].ChartType = SeriesChartType.Column;

            myChart.Series[0].Points.AddXY(100, 50);    // 인덱스 값이나 시리즈 명을 넣어주어 사용한다.
            myChart.Series["First"].Points.AddXY(200, 70);

            myChart.Series.Add("Second");
            myChart.Series[1].Points.AddXY(100, 50);
            myChart.Series["Second"].Points.AddXY(200, 65);

            double[] scores = { 70, 60, 23, 16, 100 };
            string[] names = { "둘리", "도우너", "또치", "마이콜", "길동" };
            // x데이터나 y데이터 한 축의 데이터를 주지 않으면 자동으로 1값 부터 증가한다.
            //myChart2.Series[0].Points.DataBindY(scores);
            myChart2.Series[0].Points.DataBindXY(names, scores);
            myChart2.Series[0].LegendText = "학생의 점수";

            students = new List<ChartStudent>();
            students.Add(new ChartStudent() { StuNo = "981110", Name = "홍길동", Avg = 78 });
            students.Add(new ChartStudent() { StuNo = "981111", Name = "백두산", Avg = 12 });
            students.Add(new ChartStudent() { StuNo = "981112", Name = "홍길동", Avg = 65 });

            myChart3.Series[0].Points.DataBind(students, "Name", "Avg", null);
            myChart3.Series[0].LegendText = "학생의 성적";
        }


        Point? previousPos = null;  // null을 가질 수 있는 Point 타입의 변수 선언
        ToolTip myToolTip = new ToolTip();

        private void myChart3_MouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = "x : " + e.Location.X + "y : " + e.Location.Y;

            Point position = e.Location;    // 현재 마우스 포인터의 좌표 저장
            if (previousPos.HasValue && position == previousPos)    // 좌표가 변경되지 않았다면
            {
                return;
            }

            myToolTip.RemoveAll();  // 툴팁의 모든 내용 비움
            previousPos = position;
            var hit = myChart3.HitTest(position.X, position.Y, ChartElementType.DataPoint);
            if (hit.ChartElementType == ChartElementType.DataPoint)
            {   // 현재 마우스의 위치가 DataPoint(실제 차트의 데이터가 표시된 영역) 일 때...
                //MessageBox.Show("Test");

                var yValue = (hit.Object as DataPoint).YValues[0];    // 마우스 포인터가 있는 데이터의 점수
                var xValue = students[hit.PointIndex].Name;   // 그래프가 가리키는 학생의 이름

                myToolTip.Show(xValue + "의 정수" + yValue, myChart3, new Point(position.X + 10, position.Y + 15));
            }
        }
    }
}
