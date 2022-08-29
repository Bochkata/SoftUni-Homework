using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(", ").ToArray();



                if (command[0] == "Add")
                {
                    bool flag = true;
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[j]==command[1])
                        {
                            Console.WriteLine("Card is already in the deck");
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        input.Add(command[1]);
                        Console.WriteLine("Card successfully added");
                    }     
                }



                if (command[0]=="Remove")
                {
                    bool flag = true;
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[j] == command[1])
                        {
                            Console.WriteLine("Card successfully removed");
                            input.RemoveAt(j);
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine("Card not found");
                        
                    }
                }




                if (command[0] == "Remove At")
                {
                    if (int.Parse(command[1])>=input.Count || int.Parse(command[1])<0)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        Console.WriteLine("Card successfully removed");
                        input.RemoveAt(int.Parse(command[1]));
                    }
                }
                if (command[0] == "Insert")
                {
                    if (int.Parse(command[1]) >= input.Count || int.Parse(command[1])<0)
                    {
                        Console.WriteLine("Index out of range");
                    }

                    else
                    {
                        bool flag = true;
                        for (int j = 0; j < input.Count; j++)
                        {
                            if (input[j] == command[2])
                            {
                                Console.WriteLine("Card is already added");
                                flag = false;
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            input.Insert(int.Parse(command[1]),command[2]);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(", ",input));
        }
    }
}
