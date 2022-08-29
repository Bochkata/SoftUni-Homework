using System;

namespace T03FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

           
            bool isEqual = Math.Abs(num1 - num2) < 0.000001;

            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
