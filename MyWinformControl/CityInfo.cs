using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class CityInfo
    {
        private string cityname;

        public string Cityname
        {
            get { return cityname; }
            set { cityname = value; }
        }

        private int popular;

        public int Popular
        {
            get { return popular; }
            set { popular = value; }
        }

        private int area;

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public CityInfo(string cityname, int popular, int area)
        {
            this.cityname = cityname;
            this.popular = popular;
            this.area = area;
        }
    }
}
