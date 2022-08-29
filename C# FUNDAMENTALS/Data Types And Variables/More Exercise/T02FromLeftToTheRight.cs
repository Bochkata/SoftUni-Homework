using System;
using System.Linq;
using System.Numerics;

namespace T02FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                long digitsLeftSum = 0L;
                long digitsRightSum = 0L;
                long leftNum = long.Parse(numbers[0]);
                long rightNum = long.Parse(numbers[1]);


                for (int j = 0; j < numbers[0].Length; j++)
                {
                    bool isDigit = long.TryParse(numbers[0][j].ToString(), out long digit);
                    digitsLeftSum += digit;
                }

                for (int k = 0; k < numbers[1].Length; k++)
                {
                    bool isDigit = long.TryParse(numbers[1][k].ToString(), out long digit);
                    digitsRightSum += digit;
                }

                if (leftNum > rightNum)
                {
                    Console.WriteLine(digitsLeftSum);
                }
                else
                {
                    Console.WriteLine(digitsRightSum);
                }


            }

        }
    }
}
