using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Include")
                {
                    input.Add(command[1]);
                }  




                if (command[0] == "Remove")
                {
                    if (command[1]=="first")
                    {
                        if (int.Parse(command[2])<=input.Count)
                        {
                            for (int j = 0; j < int.Parse(command[2]); j++)
                            {
                                input.RemoveAt(0);
                            }
                        }
                        else
                        {

                        }
                    }
                    if (command[1] == "last")
                    {
                        if (int.Parse(command[2]) <= input.Count)
                        {
                            for (int j = 0; j < int.Parse(command[2]); j++)
                            {
                                input.RemoveAt(input.Count-1);
                            }
                        }
                        else
                        {

                        }
                    }
                }


                if (command[0]=="Prefer")
                {
                    if (int.Parse(command[1]) < input.Count && int.Parse(command[2]) < input.Count && int.Parse(command[1]) != int.Parse(command[2]))
                    {
                        string temp = input[int.Parse(command[1])];
                        input[int.Parse(command[1])] = input[int.Parse(command[2])];
                        input[int.Parse(command[2])] = temp;
                    }
                    else
                    {

                    }
                }


                if (command[0] == "Reverse")
                {
                    input.Reverse();
                }

            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ",input));

        }
    }
}
