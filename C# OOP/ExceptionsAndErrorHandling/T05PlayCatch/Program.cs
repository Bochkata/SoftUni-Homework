using System;
using System.Collections.Generic;
using System.Linq;

namespace T05PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse).ToList();
            int numOfExceptions = 0;


            while (numOfExceptions < 3)
            {
                string[] command = Console.ReadLine().Split();
                try
                {
                    if (int.TryParse(command[1], out int result) == false)
                    {
                        numOfExceptions++;
                        throw new FormatException();
                    }
                    if (command.Length == 3)
                    {
                        if (int.TryParse(command[2], out int elem) == false)
                        {
                            numOfExceptions++;
                            throw new FormatException();
                        }
                        if (command[0] == "Replace")
                        {
                            
                            if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= integerElements.Count)
                            {
                                numOfExceptions++;
                                throw new IndexOutOfRangeException();
                            }

                            int index = int.Parse(command[1]);
                            int element = int.Parse(command[2]);
                            integerElements.RemoveAt(index);
                            integerElements.Insert(index, element);

                        }
                        else if (command[0] == "Print")
                        {
                            if (int.Parse(command[1]) < 0 || int.Parse(command[2]) >= integerElements.Count)
                            {
                                numOfExceptions++;
                                throw new IndexOutOfRangeException();
                            }

                            int startIndex = int.Parse(command[1]);
                            int endIndex = int.Parse(command[2]);
                            List<int> listToPrint =
                                integerElements.Skip(startIndex).Take(endIndex - startIndex + 1).ToList();

                            Console.WriteLine(string.Join(", ", listToPrint));
                            
                        }
                    }
                   
                    else if (command.Length == 2)
                    {
                        
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= integerElements.Count)
                        {
                            numOfExceptions++;
                            throw new IndexOutOfRangeException();
                        }

                        Console.WriteLine(integerElements[int.Parse(command[1])]);
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                }

            }

            Console.WriteLine(string.Join(", ", integerElements));
            
        }
    }
}
