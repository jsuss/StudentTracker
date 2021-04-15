using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            // While value is true, users are able to add more students
            bool adding = true;

            while(adding)
            {
                // Create new instance of Student
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
                // Check if user decided to stop adding users
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            // Extra line for formatting
            Console.WriteLine();

            // Display all students' information
            foreach (Student student in students)
                Console.WriteLine("Name: {0} - Grade: {1}", student.Name, student.Grade);

            Console.WriteLine("Student Count: {0}", Student.Count);

        }
    }
    class Student
    {
        static public int Count = 0;

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private long phone;
        public long Phone
        {
            set { phone = value; }
        }
    }
}
