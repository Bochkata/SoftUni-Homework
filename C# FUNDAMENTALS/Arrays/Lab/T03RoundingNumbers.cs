using System;
using System.Linq;

namespace T03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] arrayLineOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            for (int i = 0; i < arrayLineOfNumbers.Length; i++)
            {
                if (arrayLineOfNumbers[i] == -0.0)
                {
                    arrayLineOfNumbers[i] = 0;
                }


                Console.WriteLine(
                    $"{arrayLineOfNumbers[i]} => {(int) Math.Round(arrayLineOfNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
