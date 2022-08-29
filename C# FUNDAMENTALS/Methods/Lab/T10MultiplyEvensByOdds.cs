using System;
using System.Runtime.InteropServices;

namespace T10MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int multiplication = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

            return multiplication;

        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumEvenDigits = 0;
            int currentDigit = 0;
            while (number != 0)
            {
                currentDigit = Math.Abs(number % 10);
                if (currentDigit % 2 == 0)
                {
                    sumEvenDigits += currentDigit;
                }

                number /= 10;

            }

            return sumEvenDigits;
        }


        static int GetSumOfOddDigits(int number)
        {
            int sumOddDigits = 0;
            int currentDigit = 0;
            while (number != 0)
            {
                currentDigit = Math.Abs(number % 10);
                if (currentDigit % 2 != 0)
                {
                    sumOddDigits += currentDigit;
                }

                number /= 10;
            }

            return sumOddDigits;


        }

    }
}
