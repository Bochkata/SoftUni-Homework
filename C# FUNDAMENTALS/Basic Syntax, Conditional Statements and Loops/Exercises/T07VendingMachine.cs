using System;

namespace T07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins. 
            // Nuts", "Water", "Crisps", "Soda", "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively
            double totalInsertedMoney = 0;

            while (input != "Start")
            {
                double insertedCoins = double.Parse(input);
                if (insertedCoins == 0.10 || insertedCoins == 0.20 || insertedCoins == 0.50 ||
                    insertedCoins == 1.00 || insertedCoins == 2.00)
                {
                    totalInsertedMoney += insertedCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedCoins}");
                }

                input = Console.ReadLine();
            }

            string purchasedProduct = Console.ReadLine();

            while (purchasedProduct != "End")
            {

                if (purchasedProduct == "Nuts")
                {

                    if (totalInsertedMoney < 2.00)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalInsertedMoney -= 2.00;
                        Console.WriteLine($"Purchased nuts");
                    }
                }
                else if (purchasedProduct == "Water")
                {
                    if (totalInsertedMoney < 0.70)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalInsertedMoney -= 0.70;
                        Console.WriteLine($"Purchased water");
                    }
                }
                else if (purchasedProduct == "Crisps")
                {
                    if (totalInsertedMoney < 1.50)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalInsertedMoney -= 1.50;
                        Console.WriteLine($"Purchased crisps");
                    }
                }
                else if (purchasedProduct == "Soda")
                {
                    if (totalInsertedMoney < 0.80)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalInsertedMoney -= 0.80;
                        Console.WriteLine($"Purchased soda");
                    }
                }
                else if (purchasedProduct == "Coke")
                {
                    if (totalInsertedMoney < 1.00)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalInsertedMoney -= 1.00;
                        Console.WriteLine($"Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                purchasedProduct = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalInsertedMoney:f2}");
        }
    }
}
