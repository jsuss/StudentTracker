using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            bool adding = true;

            while(adding)
            {
                Student newStudent = new Student();

                Console.Write("Enter name: ");
                newStudent.Name = Console.ReadLine();

                students.Add(newStudent);

                Console.WriteLine("Add another student? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (Student student in students)
                Console.WriteLine("Name: {0}", student.Name);
        }
    }
    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public long Phone;
    }
}
