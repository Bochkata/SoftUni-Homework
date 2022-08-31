using System;
using System.Collections.Generic;
using System.Linq;

namespace T06FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 4)
                {
                    string citizenName = input[0];
                    int citizenAge = int.Parse(input[1]);
                    string citizenId = input[2];
                    string citizenBirthdate = input[3];
                    buyers.Add(new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate));

                }
                else if (input.Length == 3)
                {
                    string rebelName = input[0];
                    int rebelAge = int.Parse(input[1]);
                    string rebelGroup = input[2];
                    buyers.Add(new Rebel(rebelName, rebelAge, rebelGroup));
                }
                
            }

            string command;
            
            while ((command = Console.ReadLine()) !="End")
            {

                IBuyer currBuyer = buyers.FirstOrDefault(x => x.Name == command);
                //if (currBuyer != null)
                //{
                //   currBuyer.BuyFood();
                //}

                currBuyer?.BuyFood();
            }

            Console.WriteLine(buyers.Sum(x=>x.Food));
        }
    }
}
