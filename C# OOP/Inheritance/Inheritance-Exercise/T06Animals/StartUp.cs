using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string command;
            List<Animal> allAnimals = new List<Animal>();


            while ((command = Console.ReadLine()) != "Beast!")
            {

                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currName = tokens[0];
                int currAge = int.Parse(tokens[1]);
                string currGender = tokens[2];
                if (command == "Dog")
                {
                    Dog dog = new Dog(currName, currAge, currGender);
                    allAnimals.Add(dog);

                }
                else if (command == "Cat")
                {
                    Cat cat = new Cat(currName, currAge, currGender);
                    allAnimals.Add(cat);

                }
                else if (command == "Frog")
                {
                    Frog frog = new Frog(currName, currAge, currGender);
                    allAnimals.Add(frog);
                }
                else if (command == "Kitten")
                {
                    Kitten kitten = new Kitten(currName, currAge);
                    allAnimals.Add(kitten);
                }
                else if (command == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(currName, currAge);
                    allAnimals.Add(tomcat);
                }
                
            }


            foreach (Animal animal in allAnimals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }

        }
    }
}
