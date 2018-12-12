using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MyWinformControl
{
    public partial class FrmJsonEx1 : Form
    {
        public FrmJsonEx1()
        {
            InitializeComponent();
        }

        private void FrmJsonEx1_Load(object sender, EventArgs e)
        {
            var f1 = new Friends { No = 2, Name = "둘리", Mobile = "010-1111-2222", Add = "남극" };
            var f2 = new Friends { No = 43, Name = "고우든", Mobile = "010-5837-4747", Add = "까꿍" };

            var friends = new Friends[3];
            friends[0] = f1;
            friends[1] = f2;

            #region JavaScriptSerializer 이용
            var jss = new JavaScriptSerializer();
            var jsonFormat = jss.Serialize(f1);
            //MessageBox.Show(jsonFormat);

            label2.Text = jsonFormat;
            label4.Text = jss.Serialize(friends);

            System.Diagnostics.Debug.WriteLine(label4.Text);
            #endregion



            label7.Text = JsonConvert.SerializeObject(f1);
            label8.Text = JsonConvert.SerializeObject(friends);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jss = new JavaScriptSerializer();
            var f1= jss.Deserialize<Friends>(label2.Text);

            label5.Text = f1.Name;

            List<Friends> friends = new List<Friends>();
            Friends[] arr = jss.Deserialize<Friends[]>(label4.Text);    // 배열 타입으로 역직렬화
            friends = jss.Deserialize<List<Friends>>(label4.Text);  // 컬렉션 타입 역직렬화

            foreach (Friends item in friends)
            {
                if (item !=null)
                {
                label6.Text += item.Name+" ,";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = JsonConvert.DeserializeObject<Friends>(label7.Text);
            label9.Text = f1.Name;

            Friends[] fArr = JsonConvert.DeserializeObject<Friends[]>(label8.Text);

            foreach (var item in fArr)
            {
                if (item != null)
                {
                    label10.Text += item.Name;
                }
            }
        }
    }
}
