using System;
using System.Numerics;

namespace T03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= countNumbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);


        }
    }
}
