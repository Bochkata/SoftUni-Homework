using System;
using System.Collections.Generic;

namespace T04TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TribonacciSequence(number);

        }

        static void TribonacciSequence(int number)
        {

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else if (number == 1)
            {
                Console.WriteLine(1);
            }
            else if (number == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (number == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else if (number == 4)
            {
                Console.WriteLine("1 1 2 4");
            }
            else if (number >= 5)
            {

                Console.Write("1 1 2 4 ");
                int n1 = 1;
                int n2 = 1;
                int n3 = 2;
                int currentNumber = n1 + n2 + n3;

                for (int i = 4; i < number; i++)
                {
                    n1 = n2;
                    n2 = n3;
                    n3 = currentNumber;
                    currentNumber = n3 + n2 + n1;
                    Console.Write($"{currentNumber} ");
                }

            }

        }

    }
}
