using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    internal class Friends
    {
        private int no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string add;


        public string Add
        {
            get { return add; }
            set { add = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }


        public Friends(int no, string name, string mobile, string add, string image)
        {
            this.no = no;
            this.name = name;
            this.mobile = mobile;
            this.add = add;
            this.image = image;
        }

        public Friends()
        {
        }

        public override bool Equals(object obj)
        {
            var friends = obj as Friends;
            return friends != null &&
                   no == friends.no &&
                   name == friends.name &&
                   mobile == friends.mobile &&
                   add == friends.add;
        }
    }
}
