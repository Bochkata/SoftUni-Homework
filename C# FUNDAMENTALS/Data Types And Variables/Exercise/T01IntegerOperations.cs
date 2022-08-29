using System;

namespace T01IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            long operation1 = (long)(number1 + number2);
            decimal operation2 = (decimal)(operation1 / number3);
            decimal operation3 = (decimal)(operation2 * number4);
            Console.WriteLine(operation3);
        }
    }
}
