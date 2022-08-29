using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dick = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="End")
                {
                    break;
                }
                else
                {
                    string command = input[0];
                    string name = input[1];
                    if (command=="Enroll")
                    {
                        if (dick.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} is already enrolled.");
                        }
                        else
                        {
                            dick.Add(name,new List<string>());
                        }
                    }
                    if (command=="Learn")
                    {
                        string spell = input[2];
                        if (dick.ContainsKey(name))
                        {
                            if (dick[name].Contains(spell))
                            {
                                Console.WriteLine($"{name} has already learnt {spell}.");
                            }
                            else
                            {
                                dick[name].Add(spell);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                    }
                    if (command=="Unlearn")
                    {
                        string spell = input[2];
                        if (dick.ContainsKey(name))
                        {
                            if (dick[name].Contains(spell))
                            {
                       
                                dick[name].Remove(spell);
                            }
                            else
                            {
                                Console.WriteLine($"{name} doesn't know {spell}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                    }
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var item in dick.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.Write($"== {item.Key}: ");
                int counter = 0;
                foreach (var item1 in item.Value)
                {
                    counter++;
                    if (counter==1)
                    {
                        Console.Write($"{item1}");
                    }
                    else
                    {
                        Console.Write($", {item1}");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
