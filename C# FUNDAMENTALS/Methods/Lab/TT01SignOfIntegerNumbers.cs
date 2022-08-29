using System;

namespace TT01SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignChecker(number);
        }

        static void SignChecker(int number)
        {
            string sign = " ";
            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }


    }
}
