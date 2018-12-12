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
    public partial class frmChartQuiz : Form
    {
        public frmChartQuiz()
        {
            InitializeComponent();
        }

        private void frmChartQuiz_Load(object sender, EventArgs e)
        {
            List<Weather> lst = new List<Weather>();
            lst.Add(new Weather() { SumR = 1173.8, Spring = 215.9, Summer = 599.8, Fall = 293.1, Winter = 76.9, Years = "2014" });
            lst.Add(new Weather() { SumR = 949.0, Spring = 223.2, Summer = 387.1, Fall = 247.7, Winter = 109.1, Years = "2015" });
            lst.Add(new Weather() { SumR = 1272.5, Spring = 312.8, Summer = 446.2, Fall = 391.6, Winter = 108.1, Years = "2016" });
            lst.Add(new Weather() { SumR = 967.8, Spring = 118.6, Summer = 609.7, Fall = 172.5, Winter = 75.6, Years = "2017" });

            myChart.Series.Add("봄");
            myChart.Series.Add("여름");
            myChart.Series.Add("가을");
            myChart.Series.Add("겨울");
            myChart.Series[0].LegendText = "합계";
            myChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            myChart.Series[0].Color = Color.DimGray;
            myChart.Series[0].BorderColor = Color.Black;


            myChart.Series[0].Points.DataBind(lst, "Years", "SumR", null);
            myChart.Series["봄"].Points.DataBind(lst, "Years", "Spring", null);
            myChart.Series["여름"].Points.DataBind(lst, "Years", "Summer", null);
            myChart.Series["가을"].Points.DataBind(lst, "Years", "Fall", null);
            myChart.Series["겨울"].Points.DataBind(lst, "Years", "Winter", null);



        }
    }
}
