using System;

namespace T10RageExpensesVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLostGames = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;

            for (int i = 1; i <= countLostGames; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    rageExpenses += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    rageExpenses += displayPrice;
                }
            }

            //double rageExpenses = (countLostGames / 2) * headsetPrice + (countLostGames / 3) * mousePrice +
            //    (countLostGames / 6) * keyboardPrice + (countLostGames / 12) * displayPrice;


            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
