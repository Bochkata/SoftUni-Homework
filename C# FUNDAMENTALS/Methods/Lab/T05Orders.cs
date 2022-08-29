using System;
using System.Threading.Channels;

namespace T05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int numberOfProducts = int.Parse(Console.ReadLine());
            OrderPrice(product, numberOfProducts);

        }

        static void OrderPrice(string product, int quantity)
        {

            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2.00:f2}");
                    break;
            }

        }
    }
}
