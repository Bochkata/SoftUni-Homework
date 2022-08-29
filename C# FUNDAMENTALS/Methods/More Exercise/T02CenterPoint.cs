using System;
using System.Collections.Generic;

namespace T02CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());

            CenterPoint(num1, num2, num3, num4);
            
        }

        static void CenterPoint(double n1, double n2, double n3, double n4)
        {
            double result1 = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
            double result2 = Math.Sqrt(Math.Pow(n3, 2) + Math.Pow(n4, 2));
            

            if (result1 <= result2)
            {

                Console.WriteLine($"({n1}, {n2})");
            }
            else
            {
                Console.WriteLine($"({n3}, {n4})");
            }

        }
    }
}
