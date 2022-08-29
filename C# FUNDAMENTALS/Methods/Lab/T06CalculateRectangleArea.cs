using System;

namespace T06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            PrintArea(width, length);

        }

        static void PrintArea(int width, int length)
        {
            
            Console.WriteLine(width * length);
        }
    }
}
