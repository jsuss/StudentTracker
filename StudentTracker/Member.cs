using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTracker
{ 
    class Member
    {
        public string Name;
        public string Address;
        protected long phone;
        public long Phone
        {
            set { phone = value; }
            get { return phone; }
        }
    }
}
