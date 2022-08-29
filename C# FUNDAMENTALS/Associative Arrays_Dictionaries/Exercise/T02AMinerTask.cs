using System;
using System.Collections.Generic;

namespace T02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (true)
            {
               string resources = Console.ReadLine();
                if (resources == "stop")
                {
                    break;
                }
                int quantities = int.Parse(Console.ReadLine());
                
                if (!result.ContainsKey(resources))
                {
                    result[resources] = quantities;
                }
                else
                {
                    result[resources] += quantities;
                }

            }

            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
