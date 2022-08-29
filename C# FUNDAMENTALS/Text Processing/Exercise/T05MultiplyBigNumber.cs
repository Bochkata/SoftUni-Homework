using System;
using System.Text;

namespace T05MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();

            sbyte multiplier = sbyte.Parse(Console.ReadLine());

            StringBuilder finalResult = new StringBuilder();


            int figuresOfMultiplication = 0;
            int remainder = 0;
            if (multiplier == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumber.Length-1; i >= 0; i--)
            {

                figuresOfMultiplication = multiplier * int.Parse(bigNumber[i].ToString()) + remainder;
                int lastDigit = figuresOfMultiplication % 10;
                remainder = figuresOfMultiplication / 10;
                finalResult.Insert(0, lastDigit);

            }

            if (remainder != 0)
            {
                finalResult.Insert(0, remainder);
            }

            Console.WriteLine(finalResult);
        }
    }
}
