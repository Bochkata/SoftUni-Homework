using System;

namespace T02AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string randomSymbols = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < randomSymbols.Length; i++)
            {
                if (randomSymbols[i] > firstChar && randomSymbols[i] < secondChar)
                {
                    sum += randomSymbols[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
