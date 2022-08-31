using System;
using System.Collections.Generic;

namespace T09ExplicitInterfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            List<Citizen> citizens = new List<Citizen>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string citizenName = tokens[0];
                string citizenCountry = tokens[1];
                int citizenAge = int.Parse(tokens[2]);
                Citizen citizen = new Citizen(citizenName, citizenAge, citizenCountry);
                citizens.Add(citizen);
            }

            foreach (Citizen citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }

        }
    }
}
