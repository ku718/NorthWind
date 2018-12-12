using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class Accounts
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        private DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        private IList<string> role;

        public IList<string> Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}
