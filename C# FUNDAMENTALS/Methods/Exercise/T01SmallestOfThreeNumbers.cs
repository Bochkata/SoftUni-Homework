using System;


namespace Methods_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestInt(num1, num2, num3));
        }

        //static int GetSmallestInt(int a, int b, int c)
        //{
        //    int smallestInteger = int.MinValue;
        //    if (a <= b && a <= c)
        //    {
        //        smallestInteger = a;
        //    }
        //    else if (b < a && b <= c)
        //    {
        //        smallestInteger = b;
        //    }
        //    else if (c < a && c < b)
        //    {
        //        smallestInteger = c;
        //    }

        //    return smallestInteger;
        //}
        static int GetSmallestInt(int a, int b, int c)
        {
            int min = Math.Min(c, Math.Min(a, b));
            return min;

        }


    }

}
