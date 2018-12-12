using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyWinformControl
{
    public partial class FrmXmlEx1 : Form
    {
        // 
        // ------------ XML 파일 읽어오는법 ----------


        List<Friends> lstFriends = new List<Friends>();
        public FrmXmlEx1()
        {
            InitializeComponent();
        }

        private void FrmXmlEx1_Load(object sender, EventArgs e)
        {
            string xmlFilePath = @"C:\C#\C#\MyWinformControl\MyWinformControl\friends.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            XmlNodeList friendNodes = doc.DocumentElement.SelectNodes("/Friends/Friend");
            //  item ->  <friend>엘리먼트 -> friends객체로 만들 수 있다
            foreach (XmlNode item in friendNodes)
            {
                Friends f = new Friends();

                f.No = Int32.Parse(item.Attributes["no"].Value);
                f.Name = item.SelectSingleNode("Name").InnerText;
                f.Mobile = item.SelectSingleNode("Mobile").InnerText;
                f.Add = item.SelectSingleNode("Addr").InnerText;

                lstFriends.Add(f);
            }
            this.friendView.DataSource = lstFriends;
        }
    }
}
