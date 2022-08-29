using System;
using System.Collections.Generic;
using System.Linq;


namespace T06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add": numbers.Add(int.Parse(command[1])); break;
                    case "Remove": numbers.Remove(int.Parse(command[1])); break;
                    case "RemoveAt": numbers.RemoveAt(int.Parse(command[1])); break;
                    case "Insert": numbers.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
                        default:break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
