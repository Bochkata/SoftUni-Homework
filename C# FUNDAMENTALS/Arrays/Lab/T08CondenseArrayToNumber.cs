using System;
using System.Globalization;
using System.Linq;

namespace T08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] condensed = new int[numbersArray.Length];
           


            for (int i = 0; i < numbersArray.Length-1; i++)
            {
                
                for (int j = 0; j < numbersArray.Length - 1; j++)
                {
                    condensed[j] = numbersArray[j] + numbersArray[j + 1];
                    numbersArray[j] = condensed[j];

                }
            }
            

            Console.WriteLine($"{numbersArray[0]}");


        }
    }
}
