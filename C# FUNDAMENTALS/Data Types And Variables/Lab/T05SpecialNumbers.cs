using System;

namespace T05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                
                int sumOfDigits = 0;
                while (currentNumber > 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber /= 10;
                    
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
