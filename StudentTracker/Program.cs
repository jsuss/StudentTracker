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

                Console.Write("Enter name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Enter grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Enter birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Enter address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Enter phone number: ");
                newStudent.Phone = long.Parse(Console.ReadLine());

                // Add new instance of Student to students list
                students.Add(newStudent);
                
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
        }
    }
    class Student
    {
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
