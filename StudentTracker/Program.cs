using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            bool addStudents = true;

            while (addStudents)
            {
                Student newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Enter name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Enter grade: "));
                newStudent.Birthday = Util.Console.Ask("Enter birthday: ");
                newStudent.Address = Util.Console.Ask("Enter address: ");
                newStudent.Phone = long.Parse(Util.Console.Ask("Enter phone number: "));

                // Add new instance of Student to students list
                students.Add(newStudent);
                Student.Count++;

                Console.WriteLine("Add another student? y/n");
                if (Console.ReadLine() != "y")
                    addStudents = false;
            }
            // Extra line for formatting
            Console.WriteLine();

            // Display all students' information
            foreach (Student student in students)
                Console.WriteLine("Name: {0} - Grade: {1} - Phone: {2}", student.Name, student.Grade, student.Phone);

            Console.WriteLine("Student Count: {0}", Student.Count);
        }
        static void Import()
        {
            var importedStudent = new Student("Jesus", 98, "November", "301 Vermont", 7603909370);
            Console.WriteLine(importedStudent.Name);
        }
    }
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
    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;
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
    class Teacher : Member
    {
        public string Subject;
    }
}
