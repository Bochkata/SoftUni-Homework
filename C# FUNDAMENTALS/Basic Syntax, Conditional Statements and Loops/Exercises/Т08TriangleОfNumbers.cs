using System;

namespace Т08TriangleОfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");

                }
                Console.WriteLine();
                currentNumber++;
                if (currentNumber > n)
                {
                    break;
                }
            }
        }
    }
}
