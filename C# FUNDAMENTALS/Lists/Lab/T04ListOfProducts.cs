using System;
using System.Collections.Generic;


using System.Linq;

namespace T04ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(number);

            for (int i = 0; i < number; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();
            int num = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{num++}.{product}");
            }
                
            }
        }
    }

