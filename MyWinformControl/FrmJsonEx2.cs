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
    public partial class FrmJsonEx2 : Form
    {
        public FrmJsonEx2()
        {
            InitializeComponent();
        }

        private void FrmJsonEx2_Load(object sender, EventArgs e)
        {
            Accounts account = new Accounts
            {
                Email = "dooly@dooly.com",
                Active = true,
                CreateDate = DateTime.Now,
                Role = new List<string>
                {
                    "User","Admin","System Achitecture"
                }
            };
            textBox1.Text = JsonConvert.SerializeObject(account, Formatting.Indented);

            Cakes cake = new Cakes
            {
                Id = "0001",
                Type = BakeryType.Donut,
                Name = "Cake",
                Ppu = 0.55f,
                Batter = new List<Batter>
                {
                    new Batter {Id = "1001", Type="Regular"},
                    new Batter{Id="1002",Type="Chocolate"}
                },
                Topping = new List<Topping>
                {
                    new Topping{Id="5001",Type="None"},
                    new Topping{Id="5002",Type="Glazed" }
                }
            };
            textBox2.Text = JsonConvert.SerializeObject(cake, Formatting.Indented);

        }
    }
}
