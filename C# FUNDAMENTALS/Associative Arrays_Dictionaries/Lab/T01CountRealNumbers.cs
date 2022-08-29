using System;
using System.Collections.Generic;
using System.Linq;

namespace T01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();
           


            for (int i = 0; i < numbers.Count; i++)
            {
                if (result.ContainsKey(numbers[i]))
                {

                    result[numbers[i]] = result[numbers[i]] + 1;

                }
                else
                {
                    result.Add(numbers[i], 1);
                }
            }

            foreach (KeyValuePair<double, int> number in result)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
           

        }
    }
}
