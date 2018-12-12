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
    public partial class frmBooksEx1 : Form
    {
        List<Books> lstbooks = new List<Books>();
        public frmBooksEx1()
        {
            InitializeComponent();
        }

        private void frmBooksEx1_Load(object sender, EventArgs e)
        {
            string xmlFilePath = @"C:\C#\C#\MyWinformControl\MyWinformControl\booksEx1.xml"; 
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            XmlNodeList booksNodes = doc.DocumentElement.SelectNodes("/bookstore/book");
            foreach (XmlNode item in booksNodes)
            {
                Books b = new Books();

                b.Category = item.Attributes["category"].Value;
                b.Title = item.SelectSingleNode("title").InnerText;
                b.Language = item.SelectSingleNode("title").Attributes["lang"].Value;
                //b.Author = item.SelectSingleNode("author").InnerText;
                foreach (XmlNode subitem in item.ChildNodes)
                {
                    if(subitem.Name == "author")
                    {
                        b.Author += subitem.InnerText + ", ";
                    }
                }
                //b.Author = b.Author.Substring(0, b.Author.Length - 2);
                b.Author = b.Author.Trim().TrimEnd(',');
                b.Year = Int32.Parse(item.SelectSingleNode("year").InnerText);
                b.Price = float.Parse(item.SelectSingleNode("price").InnerText);

                if (item.Attributes["cover"] != null)
                {
                    b.Cover = item.Attributes["cover"].Value;
                }

                lstbooks.Add(b);
            }
            this.booksView.DataSource = lstbooks;
        }
    }
}
