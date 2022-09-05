using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam20Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse));
            var flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse));
            var dick = new Dictionary<string, int>();


            while (flour.Count>0 && water.Count>0)
            {
                var currWater = water.Peek();
                var currFlour = flour.Peek();
                var sum = currWater + currFlour;

                if (currFlour == currWater)
                {
                    if (dick.ContainsKey("Croissant"))
                    {
                        dick["Croissant"]++;
                    }
                    else
                    {
                        dick.Add("Croissant", 1);
                    }
                    water.Dequeue();
                    flour.Pop();
                }

            

                else if ((currWater * 100) / sum == 30)
                {
                    if (dick.ContainsKey("Baguette"))
                    {
                        dick["Baguette"] ++;
                    }
                    else
                    {
                        dick.Add("Baguette", 1);
                    }

                    water.Dequeue();
                    flour.Pop();
                }

                else if ((currWater * 100) / sum == 40)
                {
                    if (dick.ContainsKey("Muffin"))
                    {
                        dick["Muffin"]++;
                    }
                    else
                    {
                        dick.Add("Muffin", 1);
                    }

                    water.Dequeue();
                    flour.Pop();
                }
                else if ((currWater * 100) / sum == 20)
                {
                    if (dick.ContainsKey("Bagel"))
                    {
                        dick["Bagel"] ++;
                    }
                    else
                    {
                        dick.Add("Bagel", 1);
                    }

                    water.Dequeue();
                    flour.Pop();
                }
                else 
                {
                    water.Dequeue();
                    flour.Push(flour.Pop() - currWater);
                    if (dick.ContainsKey("Croissant"))
                    {
                        dick["Croissant"] ++;
                    }
                    else
                    {
                        dick.Add("Croissant", 1);
                    }

                }
            }

            foreach (var item in dick.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            if (water.Count < 1)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }
            if (flour.Count < 1)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
