using System;
using System.Collections.Generic;
using System.Linq;


namespace T05Students2._0
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


                if (hasRepetativePerson(allStudents, firstName, lastName))
                {

                    GetNextStudent(allStudents, firstName, lastName, age, homeCity);
                }
                else
                {
                    Student student = new Student()
                    {
                        firstNm = firstName,
                        lastNm = lastName,
                        years = age,
                        homeTown = homeCity

                    };
                    allStudents.Add(student);

                }


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

        static bool hasRepetativePerson(List<Student> ourStudents, string name, string surname)
        {
            foreach (Student person in ourStudents)
            {
                if (person.firstNm == name && person.lastNm == surname)
                {
                    return true;
                }

            }
            return false;

        }


        static Student GetNextStudent(List<Student> ourStudents, string firstN, string lastN, int age, string city)
        {

            Student repetativePerson = new Student();
            foreach (Student person in ourStudents)
            {

                if (person.firstNm == firstN && person.lastNm == lastN)
                {
                    repetativePerson = person;
                    repetativePerson.years = age;
                    repetativePerson.homeTown = city;
                }
            }

            return repetativePerson;
        }
    }
}
