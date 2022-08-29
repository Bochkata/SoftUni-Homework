using System;
using System.Numerics;

namespace T08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            BigInteger factorial1 = Factorial(num1);
            BigInteger factorial2 = Factorial(num2);
            
            Console.WriteLine($"{(decimal)factorial1 / (decimal)factorial2:f2}");

        }

        static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }

            if (number == 0)
            {
                factorial = 1;
            }

            return factorial;

        }
    }
}
