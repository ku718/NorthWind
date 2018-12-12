using Newtonsoft.Json;
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
    public partial class FrmJsonQuiz1 : Form
    {
        public FrmJsonQuiz1()
        {
            InitializeComponent();
        }

        private void FrmJsonQuiz1_Load(object sender, EventArgs e)
        {
            JsonQuiz1 jsq1 = new JsonQuiz1
            {
                Fruits = new string[] { FruitsType.apple.ToString(), FruitsType.orange.ToString(), FruitsType.pear.ToString() },
                Vegetables = new List<Vegetables>
                {
                    new Vegetables{VeggieName="potato",VeggieLike=true },
                    new Vegetables{VeggieName="broccoli",VeggieLike=false }
                }
            };
            this.textBox1.Text= JsonConvert.SerializeObject(jsq1, Formatting.Indented);
        }
    }
}
