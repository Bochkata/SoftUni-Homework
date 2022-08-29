using System;
using System.Collections.Generic;
using System.Linq;



namespace T07ListManipulationAdvanced
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
           
            bool hasChange = false;
            while (command[0] != "end")
            {
                
                switch (command[0])
                {
                    case "Add": numbers.Add(int.Parse(command[1]));
                        hasChange = true;break;
                    case "Remove": numbers.Remove(int.Parse(command[1]));
                        hasChange = true;break;
                    case "RemoveAt": numbers.RemoveAt(int.Parse(command[1]));
                        hasChange = true;break;
                    case "Insert": numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        hasChange = true; break;
                        
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        List<int> newList = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            
                            if (command[1] == "<" && numbers[i] < int.Parse(command[2]))
                            {
                                
                                newList.Add(numbers[i]);
                            }
                           if (command[1] == ">" && numbers[i] > int.Parse(command[2]))
                            {
                                newList.Add(numbers[i]);
                            }
                            if (command[1] == ">=" && numbers[i] >= int.Parse(command[2]))
                            {
                                newList.Add(numbers[i]);
                            }
                            if (command[1] == "<=" && numbers[i] <= int.Parse(command[2]))
                            {
                                newList.Add(numbers[i]);
                            }

                        }

                        
                        Console.WriteLine(string.Join(" ", newList));
                        break;
                }



                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            }

            if (hasChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
