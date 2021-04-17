using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTracker
{
    class Student : Member
    {
        static public int Count { get; set; } = 0;
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }
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
