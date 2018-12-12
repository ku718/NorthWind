using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class ShoppingInfo
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

        private int lprice;

        public int Lprice
        {
            get { return lprice; }
            set { lprice = value; }
        }

        private int hprice;

        public int Hprice
        {
            get { return hprice; }
            set { hprice = value; }
        }

        private string mallName;

        public string MallName
        {
            get { return mallName; }
            set { mallName = value; }
        }

        private double productId;

        public double ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private int productType;

        public int ProductType
        {
            get { return productType; }
            set { productType = value; }
        }


    }
}
