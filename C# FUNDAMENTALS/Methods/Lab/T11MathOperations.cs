using System;

namespace T11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            double sum = MathOperations(num1, operation, num2);
            Console.WriteLine(sum);


        }

        static double MathOperations(double input1, string mathOperationsSign, double input2)
        {
            double result = 0;
            switch (mathOperationsSign)
            {
                case "/": result = input1 / input2; break;
                case "*": result = input1 * input2; break;
                case "+": result = input1 + input2; break;
                case "-": result = input1 - input2; break;
            }

            return result;
        }


    }
}
