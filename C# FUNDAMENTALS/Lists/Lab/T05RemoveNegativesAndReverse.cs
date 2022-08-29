using System;
using System.Collections.Generic;
using System.Linq;

namespace T05RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .Where(n => n >= 0)
            //    .Reverse()
            //    .ToList();


            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }

            //numbers.RemoveAll(n => n < 0);


            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(String.Join(" ", numbers));
            }


        }
    }
}
