using System;
using System.Collections.Generic;
using System.Linq;


namespace T04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Student> allStudents = new List<Student>();

            while (studentsInfo[0] != "end")
            {

                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                int age = int.Parse(studentsInfo[2]);
                string homeCity = studentsInfo[3];

                Student student = new Student()
                {
                    firstNm = firstName,
                    lastNm = lastName,
                    years = age,
                    homeTown = homeCity

                };

                allStudents.Add(student);

                studentsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string town = Console.ReadLine();

            foreach (Student person in allStudents)
            {
                if (person.homeTown == town)
                {
                    Console.WriteLine($"{person.firstNm} {person.lastNm} is {person.years} years old.");
                }
            }


        }
        class Student
        {
            public string firstNm { get; set; }
            public string lastNm { get; set; }
            public int years { get; set; }
            public string homeTown { get; set; }
        }
    }
}
