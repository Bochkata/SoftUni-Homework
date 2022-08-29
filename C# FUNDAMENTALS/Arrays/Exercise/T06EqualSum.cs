using System;
using System.Linq;

namespace T06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i <= numbers.Length-1; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum = 0;
                for (int j = 0; j <= i-1; j++)
                {
                    leftSum += numbers[j];
                }

                rightSum = 0;
                for (int k = i+1; k <= numbers.Length-1; k++)
                {
                    rightSum += numbers[k];

                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                
            }

            Console.WriteLine("no");


        }
    }
}
