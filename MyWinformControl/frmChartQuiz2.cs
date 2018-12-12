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
    public partial class frmChartQuiz2 : Form
    {
        List<SignUp> lst;
        ToolTip ttip = new ToolTip();
        Point? previousPos = null;

        public frmChartQuiz2()
        {
            InitializeComponent();
        }

        private void frmChartQuiz2_Load(object sender, EventArgs e)
        {
            myChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            lst = new List<SignUp>();
            lst.Add(new SignUp() { SignUpTitle = "Word", RespondentCount = 20 });
            lst.Add(new SignUp() { SignUpTitle = "Excel", RespondentCount = 50 });
            lst.Add(new SignUp() { SignUpTitle = "PowerPoint", RespondentCount = 40 });
            lst.Add(new SignUp() { SignUpTitle = "Access", RespondentCount = 40 });

            myChart.Series[0].Points.DataBind(lst, "SignUpTitle", "RespondentCount", null);
        }

        private void myChart_MouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.Location;
            if (previousPos.HasValue && position == previousPos)
            {
                return;
            }

            previousPos = position;
            var v = myChart.HitTest(position.X, position.Y);
            if (v.ChartElementType == ChartElementType.DataPoint)
            {
                var xValue = lst[v.PointIndex].SignUpTitle;
                var yValue = ((DataPoint)v.Object).YValues[0];
                int sum = 0;
                foreach (var item in lst)
                {
                    sum += item.RespondentCount;
                }
                ttip.Show("수강과정 " + xValue + "응답자수 " + yValue , myChart, new Point(position.X + 10, position.Y + 15));
            }
        }
    }
}
