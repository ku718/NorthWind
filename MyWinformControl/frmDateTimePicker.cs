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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cal1.Value.ToString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.label1.Text = "현재날짜 : "+this.cal2.TodayDate.ToString();
            this.label1.Text += "\n선택된날짜 : " + this.cal2.SelectionRange.Start + " ~ " + this.cal2.SelectionRange.End;
        }
    }
}
