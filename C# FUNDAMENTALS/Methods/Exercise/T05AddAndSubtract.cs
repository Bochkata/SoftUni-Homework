using System;

namespace T05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            Console.WriteLine(sum - num3);

        }

        static int Subtract(int num01, int num02)
        {
            return num01 - num02;
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
