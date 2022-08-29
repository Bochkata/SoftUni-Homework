using System;

namespace T06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string currNumber = number.ToString();

            
            int factorialSum = 0;

            for (int i = 0; i < currNumber.Length; i++)
            {
                int currDigit = int.Parse(currNumber[i].ToString());
                int factorialCurrDigit = 1;
                for (int j = 1; j <= currDigit; j++)
                {
                    factorialCurrDigit *= j;
                }
                factorialSum += factorialCurrDigit;
            }
            string output = factorialSum == number ? "yes" : "no";
            Console.WriteLine(output);
        }
    }
}
