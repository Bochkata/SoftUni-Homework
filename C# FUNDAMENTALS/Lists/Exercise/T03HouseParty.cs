using System;
using System.Collections.Generic;
using System.Linq;

namespace T03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());


            List<string> guests = new List<string>();


            while (numberOfCommands > 0)
            {
                List<string> commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                numberOfCommands--;

                if (commands[2] == "going!")
                {
                    if (!guests.Contains(commands[0]))
                    {
                        guests.Add(commands[0]);
                    }
                    else if (guests.Contains(commands[0]))
                    {

                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }


                }
                else if (commands[2] == "not")
                {
                    if (guests.Contains(commands[0]))
                    {
                        guests.Remove(commands[0]);
                    }
                    else if (!guests.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }

                }
            }


            Console.WriteLine(string.Join("\n", guests));

        }
    }
}
