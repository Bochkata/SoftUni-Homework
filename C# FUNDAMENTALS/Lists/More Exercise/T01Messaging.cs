using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T01Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentSum = 0;
                while (numbers[i] > 0)
                {
                    currentSum += numbers[i] % 10;
                    numbers[i] /= 10;
                }

                while (currentSum >= text.Length)
                {
                    currentSum -= text.Length;
                }

                sb.Append(text[currentSum]);
                text = text.Remove(currentSum, 1);

            }

            Console.WriteLine(sb);
        }
    }
}
