using System;
using System.Linq;

namespace T07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int countEquals = 0;
            int maxEquals = 0;
            int myNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    countEquals++;
                }
                else
                {
                    countEquals = 0;
                }
                if (maxEquals < countEquals)
                {
                    maxEquals = countEquals;
                    myNumber = numbers[i];

                }
            }

            for (int j = 0; j <= maxEquals; j++)
            {
                Console.Write(myNumber + " ");
            }



        }
    }
}
