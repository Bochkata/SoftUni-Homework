using System;
using System.Collections.Generic;
using System.Linq;


namespace T04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(String.Join(" ", Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).OrderByDescending(x => x).Take(3).ToList()));

            //int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse).OrderByDescending(x => x).ToArray();

            //int count = numbers.Length >= 3 ? 3 : numbers.Length;

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}





        }
    }
}
