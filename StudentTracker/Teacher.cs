using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTracker
{
    class Teacher : Member, IPayee
    {
        public string Subject;

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
