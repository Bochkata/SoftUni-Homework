using System;

namespace T02Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            // divisible by the following numbers: 2, 3, 6, 7, 10. You should always take the bigger division.
            if (number % 10 == 0)
                Console.WriteLine("The number is divisible by 10");
            else if (number % 7 == 0)
                Console.WriteLine("The number is divisible by 7");
            else if (number % 6== 0)
                Console.WriteLine("The number is divisible by 6");
            else if (number % 3 == 0)
                Console.WriteLine("The number is divisible by 3");
            else if (number % 2 == 0)
                Console.WriteLine("The number is divisible by 2");
            else
                Console.WriteLine("Not divisible");
        }
    }
}
