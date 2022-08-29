using System;
using System.Collections.Generic;
using System.Linq;

namespace T07OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Person> allPersons = new List<Person>();

            while (input[0] != "End")
            {
                string personName = input[0];
                string personID = input[1];
                int personAge = int.Parse(input[2]);

                Person repetativePerson = allPersons.FirstOrDefault(item => item.ID == personID);

                if (repetativePerson == null)
                {
                    Person person = new Person();
                    {
                        person.Name = personName;
                        person.ID = personID;
                        person.Age = personAge;

                    }
                    allPersons.Add(person);
                }
                else
                {
                    repetativePerson.Name = personName;
                    repetativePerson.ID = personID;
                    repetativePerson.Age = personAge;
                }
               
                
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            allPersons = allPersons.OrderBy(item => item.Age).ToList();

            foreach (Person person in allPersons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
    }
}
