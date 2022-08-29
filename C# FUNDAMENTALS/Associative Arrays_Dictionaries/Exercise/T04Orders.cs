using System;
using System.Collections.Generic;

namespace T04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> quantityResult = new Dictionary<string, int>();

            Dictionary<string, double> finalPriceResult = new Dictionary<string, double>();

            while (input != "buy")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string productName = tokens[0];
                double singlePrice = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);


                if (!finalPriceResult.ContainsKey(productName))
                {
                    quantityResult[productName] = quantity;
                    finalPriceResult[productName] = quantity * singlePrice;

                }
                else
                {
                    quantityResult[productName] += quantity;
                    finalPriceResult[productName] = quantityResult[productName] * singlePrice;
                }

                input = Console.ReadLine();

            }

            foreach (KeyValuePair<string, double> item in finalPriceResult)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

           
        }
    }
}
