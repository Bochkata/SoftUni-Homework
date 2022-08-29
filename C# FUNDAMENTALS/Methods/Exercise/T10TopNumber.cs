using System;

namespace T10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if (TopInteger(i) == true)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool TopInteger(int input)
        {
            bool hasOddDigit = false;
            bool isSumDivisibleBy8 = false;
            int digitsSum = 0;
            while (input > 0)
            {
                int currentDigit = input % 10;
                if (currentDigit % 2 != 0)
                {
                    hasOddDigit = true;

                }

                digitsSum += currentDigit;
                input /= 10;

            }

            if (digitsSum % 8 == 0)
            {
                isSumDivisibleBy8 = true;
            }


            return isSumDivisibleBy8 && hasOddDigit ? true : false;
        }
    }
}
