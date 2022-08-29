using System;

namespace T09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfOdds = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numberOfOdds; i++)
            {
                Console.WriteLine(i * 2 -1);
                sum += i*2-1;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
