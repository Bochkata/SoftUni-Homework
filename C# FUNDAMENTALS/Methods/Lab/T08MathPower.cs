using System;
using System.Diagnostics;

namespace T08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double result = PrinterPower(num, pow);
            Console.WriteLine($"{result}");
            

        }

        static double PrinterPower(double number, int power)
        {
            //double result = 1;
            //for (int i = 0; i < power; i++)
            //{
            //    result *= number;
            //}

            //return result;

            double result = Math.Pow(number, power);
            return result;
        }
    }
}
