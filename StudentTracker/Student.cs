using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTracker
{
    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;
        public School School;
        public Student() { }
        public Student(string name, int grade, string birthday, string address, long phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}
