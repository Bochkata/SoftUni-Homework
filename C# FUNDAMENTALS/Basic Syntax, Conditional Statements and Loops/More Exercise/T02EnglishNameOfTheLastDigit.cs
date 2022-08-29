using System;

namespace T02EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberToString = number.ToString();

            int numberLength = numberToString.Length;

            char lastDigit = numberToString[numberLength - 1];

            if (lastDigit == 48)
            {
                Console.WriteLine("zero");
            }
            else if (lastDigit == 49)
            {
                Console.WriteLine("one");
            }
            else if (lastDigit == 50)
            {
                Console.WriteLine("two");
            }
            else if (lastDigit == 51)
            {
                Console.WriteLine("three");
            }
            else if (lastDigit == 52)
            {
                Console.WriteLine("four");
            }
            else if (lastDigit == 53)
            {
                Console.WriteLine("five");
            }
            else if (lastDigit == 54)
            {
                Console.WriteLine("six");
            }
            else if (lastDigit == 55)
            {
                Console.WriteLine("seven");
            }
            else if (lastDigit == 56)
            {
                Console.WriteLine("eight");
            }
            else if (lastDigit == 57)
            {
                Console.WriteLine("nine");
            }


        }
    }
}
