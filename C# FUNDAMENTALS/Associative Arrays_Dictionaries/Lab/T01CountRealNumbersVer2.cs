using System;
using System.Collections.Generic;
using System.Linq;

namespace T01CountRealNumbersVer2
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
                if (!result.ContainsKey(numbers[i]))
                {
                    result.Add(numbers[i], 0);
                }

                result[numbers[i]]++;
            }

            foreach (KeyValuePair<double, int> item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
