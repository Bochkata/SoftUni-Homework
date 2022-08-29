using System;

namespace T02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal GBP = decimal.Parse(Console.ReadLine());
            decimal USD = GBP * 1.31M;
            Console.WriteLine("{0:f3}", USD);
        }
    }
}
