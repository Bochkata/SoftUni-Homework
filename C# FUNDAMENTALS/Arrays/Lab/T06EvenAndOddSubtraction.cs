using System;
using System.Linq;

namespace T06EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int sumEvenValues = 0;
            int sumOddValues = 0;

            for (int i = 0; i < values.Length; i++)
            {
                int number = values[i];
                if (number % 2 == 0)
                {
                    sumEvenValues += number;
                }
                else
                {
                    sumOddValues += number;
                }
            }

            Console.WriteLine($"{sumEvenValues-sumOddValues}");
        }
    }
}
