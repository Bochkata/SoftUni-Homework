using System;
using System.Collections.Generic;

using System.Linq;

namespace T04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string commands = Console.ReadLine();

           
            while (commands != "End")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }

                if (tokens[0] == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int numberToInsert = int.Parse(tokens[1]);
                        numbers.Insert(index, numberToInsert);
                    }

                    
                }

                if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }

                   
                }

                if (tokens[0] == "Shift" && tokens[1] == "left")
                {
                    int counts = int.Parse(tokens[2]);
                    
                    for (int i = 0; i < counts; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                       

                    }
                }
                if (tokens[0] == "Shift" && tokens[1] == "right")
                {
                    int count = int.Parse(tokens[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1];

                        for (int j = 0; j < numbers.Count-1; j++)
                        {
                            
                            numbers[numbers.Count - 1 - j] = numbers[numbers.Count - 2 - j];
                            
                        }

                        numbers[0] = lastNumber;
                    }
                }


                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
            

            
        }
    }
}
