using System;
using System.Collections.Generic;

using System.Linq;

namespace Lists___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int maxCapacityPerWagon = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (command[0] != "end")
            {
                if (command[0] != "Add")
                {
                    int incomingPassengers = int.Parse(command[0]);
                    for (int i = 0; i < passengersInWagons.Count; i++)
                    {
                        if (incomingPassengers + passengersInWagons[i] <= maxCapacityPerWagon)
                        {
                            passengersInWagons[i] += incomingPassengers;
                            break;
                        }
                        
                    }

                }
                else if (command[0] == "Add")
                {
                    
                    passengersInWagons.Add(int.Parse(command[1]));

                }


                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine(string.Join(" ", passengersInWagons));
        }
    }
}
