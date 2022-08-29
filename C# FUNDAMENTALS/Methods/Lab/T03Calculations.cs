using System;

namespace T03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            switch (command)
            {
                case "add": Add(num1, num2);
                    break;
                case "multiply": Multiply(num1, num2);
                    break;
                case "subtract": Subtract(num1, num2);
                    break;
                case "divide": Divide(num1, num2);
                    break;
                default:break;

            }

        }

        static void Add(double number1, double number2)
        {

            Console.WriteLine(number1 + number2);
        }
        static void Multiply(double number1, double number2)

        {
            Console.WriteLine(number1 *= number2);

        }
        static void Subtract(double number1, double number2)

        {
            Console.WriteLine(Math.Abs(number1 -= number2));

        }
        static void Divide(double number1, double number2)
        {
            Console.WriteLine(number1 /= number2);
        }


    
}
}
