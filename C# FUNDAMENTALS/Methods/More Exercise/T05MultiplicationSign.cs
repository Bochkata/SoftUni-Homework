using System;

namespace T05MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplicationSign(num1, num2, num3));
            
        }

        static string MultiplicationSign(int n1, int n2, int n3)
        {
            string result;
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                result = "zero";
            }
            else if ((n1 > 0 && n2 > 0 && n3 > 0) || (n1 < 0 && n2 < 0 && n3 > 0) || (n1 < 0 && n3 < 0 && n2 > 0) || (n2 < 0 && n3 < 0 && n1 > 0))
            {
                result = "positive";

            }
            else
            {
                result = "negative";

            }

            return result;
        }
    }
}
