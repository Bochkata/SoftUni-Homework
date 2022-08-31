using System;
using System.Collections.Generic;
using System.Linq;
using T04BorderControl;

namespace T05BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {

            string command;
            List<IBirthable> birthables = new List<IBirthable>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == nameof(Citizen))
                {

                    string citizenName = tokens[1];
                    int citizenAge = int.Parse(tokens[2]);
                    string citizenId = tokens[3];
                    string citizenBirthdate = tokens[4];
                    birthables.Add(new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate));
                }
                else if (tokens[0] == nameof(Pet))
                {
                    string petName = tokens[1];
                    string petBirthdate = tokens[2];
                    birthables.Add(new Pet(petName, petBirthdate));

                }
            }
            string YearToFind = Console.ReadLine();
            List<IBirthable> filteredBirthables = birthables.Where(x => x.Birthdate.EndsWith(YearToFind)).ToList();

            foreach (IBirthable birthable in filteredBirthables)
            {
                Console.WriteLine(birthable.Birthdate);
            }

        }
    }
}
