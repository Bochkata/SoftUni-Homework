using System;
using System.Collections.Generic;
using System.Linq;

namespace T02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> result = new Dictionary<string, int>();
            

            foreach (string element in words)
            {
                string item = element.ToLower();
                if (!result.ContainsKey(item))
                {
                    result.Add(item, 0);
                }

                result[item]++;

            }

            foreach (KeyValuePair<string, int> item in result)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
