using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyWinformControl
{
    public partial class FrmDatabaseXML : Form
    {
        //
        // --------- DB에서 데이터를 꺼내와 XML 파일로 만드는 법 -----
        //



        public FrmDatabaseXML()
        {
            InitializeComponent();
        }

        private void FrmDatabaseXML_Load(object sender, EventArgs e)
        {
            //string conStr = ConfigurationManager.ConnectionStrings["SQLConStr"].ConnectionString;
            using (SqlConnection con = DBConnection.Connecting())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEntryFriends";

                XmlDocument doc = new XmlDocument();
                doc.CreateXmlDeclaration("1.0", "utf-8", null);
                XmlNode root = doc.CreateElement("Friends");
                doc.AppendChild(root);

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    XmlElement friend = doc.CreateElement("Friend");
                    friend.SetAttribute("no", dr["no"].ToString());
                    root.AppendChild(friend);
                    XmlElement name = doc.CreateElement("Name");
                    name.InnerText = dr["name"].ToString();
                    friend.AppendChild(name);
                    XmlElement mobile = doc.CreateElement("Mobile");
                    mobile.InnerText = dr["mobile"].ToString();
                    friend.AppendChild(mobile);
                    XmlElement addr = doc.CreateElement("Addr");
                    addr.InnerText = dr["addr"].ToString();
                    friend.AppendChild(addr);
                }
                dr.Close();

                XmlTextWriter xtw = new XmlTextWriter(@"C:\C#\C#\MyWinformControl\MyWinformControl\XMLFriends", Encoding.UTF8);
                xtw.Formatting = Formatting.Indented; 

                doc.WriteContentTo(xtw); 
                xtw.Flush();
                xtw.Close();

            }
        }
    }
}
