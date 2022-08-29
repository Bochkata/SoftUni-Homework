using System;
using System.Collections.Generic;
using System.Linq;

namespace T02OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            
            Family newFamily = new Family();
          
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string currentName = input[0];
                int currentAge = int.Parse(input[1]);

                Person newPerson = new Person();
                {
                    newPerson.Name = currentName;
                    newPerson.Age = currentAge;
                }
                newFamily.AddMember(newPerson);
               

            }

            Person oldest = newFamily.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");


        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


        }
        class Family
        {
            public List<Person> FamilyMembers = new List<Person>();

            public void AddMember(Person newMember)
            {
                FamilyMembers.Add(newMember);
            }

            public Person GetOldestMember()
            {
                Person oldestMember = FamilyMembers.OrderByDescending(x => x.Age).First();
                return oldestMember;
            }
            

        }
    }

}
