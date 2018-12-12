using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    public class BookInfo : IComparer
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private DateTime pubDate;

        public DateTime PubDate
        {
            get { return pubDate; }
            set { pubDate = value; }
        }

        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Compare(object x, object y)
        {
            int result;
            BookInfo b1 = (BookInfo)x;
            BookInfo b2 = (BookInfo)y;

            if (b1.price > b2.price)
            {
                // 앞의 객체 가격이 더 크면 양수 반환
                result = 1;
            }
            else if (b1.price == b2.price)
            {
                // 가격이 같다면 0반환
                result = 0;
            }
            else
            {
                // 뒤의 객체 가격이 더 크면 음수 반환
                result = -1;
            }
            return result;
        }
    }
}
