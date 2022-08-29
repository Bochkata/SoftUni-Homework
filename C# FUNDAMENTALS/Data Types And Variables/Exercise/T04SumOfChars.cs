using System;

namespace T04SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                sum += char.Parse(Console.ReadLine());

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
