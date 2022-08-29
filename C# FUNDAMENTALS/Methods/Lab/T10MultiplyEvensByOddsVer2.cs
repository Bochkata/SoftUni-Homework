using System;

namespace T10MultiplyEvensByOddsVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Math.Abs(int.Parse(Console.ReadLine()));

            int evenDigitsSum = GetDigitsSum(value, 0);
            int oddDigitsSum = GetDigitsSum(value, 1);
            Console.WriteLine(evenDigitsSum * oddDigitsSum);


        }

        static int GetDigitsSum(int number, int evenOddCheck)
        {
            int sumDigits = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == evenOddCheck)
                {
                    sumDigits += currentDigit;
                }

                number /= 10;

            }

            return sumDigits;
        }
    
    }
}
