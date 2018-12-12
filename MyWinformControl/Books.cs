using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class Books
    {
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string language;

        public string Language
        {
            get { return language; }
            set { language = value; }
        }



        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private string cover;

        public string Cover
        {
            get { return cover; }
            set { cover = value; }
        }

        public Books()
        {
        }

        public Books(string category, string title, string language, string author, int year, float price, string cover)
        {
            this.category = category;
            this.title = title;
            this.language = language;
            this.author = author;
            this.year = year;
            this.price = price;
            this.cover = cover;
        }
    }
}
