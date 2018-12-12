using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class JsonQuiz1
    {
        private string[] fruits;

        public string[] Fruits
        {
            get { return fruits; }
            set { fruits = value; }
        }

        private List<Vegetables> vegetables;

        public List<Vegetables> Vegetables
        {
            get { return vegetables; }
            set { vegetables = value; }
        }
    }
}
