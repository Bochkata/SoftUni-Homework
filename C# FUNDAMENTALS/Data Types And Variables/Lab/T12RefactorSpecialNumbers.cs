using System;

namespace T12RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numbers; i++)
            {
                int currentNumber = i;
                int sumOfDigits = 0;
                bool isSpecialNum = false;
                
                while (currentNumber > 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
                
            }

        }
    }
}
