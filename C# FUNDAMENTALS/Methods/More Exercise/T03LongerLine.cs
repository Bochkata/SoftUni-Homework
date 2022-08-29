using System;

namespace T03LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        static void CenterPoint(double n1, double n2, double n3, double n4)
        {
            double result1 = Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
            double result2 = Math.Sqrt(Math.Pow(n3, 2) + Math.Pow(n4, 2));


            if (result1 <= result2)
            {

                Console.WriteLine($"({n1}, {n2})({n3}, {n4})");
            }
            else
            {
                Console.WriteLine($"({n3}, {n4})({n1}, {n2})");
            }

        }

        static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            double firstLine = Math.Sqrt((Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2)));
            double secondLine = Math.Sqrt((Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2)));

            if (firstLine >= secondLine)
            {
                CenterPoint(x1, y1, x2, y2);
            }
            else
            {
                CenterPoint(x3, y3, x4, y4);
            }

        }
    }
}
