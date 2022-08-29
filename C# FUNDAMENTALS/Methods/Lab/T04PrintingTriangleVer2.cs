using System;
using System.Net;

namespace T04PrintingTriangleVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=number; i++)
            {
                PrintTriangle(i);
            }

            for (int i = number - 1; i >=1; i--)
            {
                PrintTriangle(i);
            }

        }

        static void PrintTriangle(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
       

        
    }
}
