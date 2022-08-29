using System;
using System.Collections.Generic;
using System.Linq;

namespace T02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    int indexToUse = int.Parse(tokens[2]);
                    int numberToInsert = int.Parse(tokens[1]);
                    integersList.Insert(indexToUse, numberToInsert);
                    
                }
                else if (tokens.Length == 2)
                {
                    int elementToDelete = int.Parse(tokens[1]);
                    integersList.RemoveAll(x => x == elementToDelete);
                    
                }

                commands = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", integersList));
        }
    }
}
