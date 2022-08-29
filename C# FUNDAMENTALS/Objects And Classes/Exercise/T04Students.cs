using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace T04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> allStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] student = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = student[0];
                string surname = student[1];
                double grade = double.Parse(student[2]);

                Student newStudent = new Student(name, surname, grade);
                
                allStudents.Add(newStudent);

            }

            allStudents = allStudents.OrderByDescending(el => el.Grade).ToList();
            foreach (Student person in allStudents)
            {
                Console.WriteLine(person);
            }
            //allStudents.ForEach(Console.WriteLine);

        }

        class Student
        {
            public Student(string firstNm, string lastNm, double grade)
            {
                FirstName = firstNm;
                LastName = lastNm;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }


            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
