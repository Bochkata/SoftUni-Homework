using System;

namespace T03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name                         Price
            //OutFall 4                     $39.99
            //CS: OG                        $15.99
            //Zplinter Zell	                $19.99
            //Honored 2                     $59.99
            //RoverWatch                    $29.99
            //RoverWatch Origins Edition    $39.99
            double currentBalance = double.Parse(Console.ReadLine());

            string gameBought = Console.ReadLine();

            double productPrice = 0;
            double spentMoney = 0;

            while (gameBought != "Game Time")
            {
                switch (gameBought)
                {
                    case "OutFall 4": productPrice = 39.99; break;
                    case "CS: OG": productPrice = 15.99; break;
                    case "Zplinter Zell": productPrice = 19.99; break;
                    case "Honored 2": productPrice = 59.99; break;
                    case "RoverWatch": productPrice = 29.99; break;
                    case "RoverWatch Origins Edition": productPrice = 39.99; break;
                    default:
                        break;
                }
                if (gameBought != "OutFall 4" && gameBought != "CS: OG" && gameBought != "Zplinter Zell" &&
                    gameBought != "Honored 2" && gameBought != "RoverWatch" && gameBought != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");

                }
                else if (gameBought == "OutFall 4" || gameBought == "CS: OG" || gameBought == "Zplinter Zell" ||
                    gameBought == "Honored 2" || gameBought == "RoverWatch" || gameBought == "RoverWatch Origins Edition")
                {

                    currentBalance -= productPrice;

                    if (currentBalance > 0)
                    {

                        Console.WriteLine($"Bought {gameBought}");
                        spentMoney += productPrice;
                    }
                    else if (currentBalance == 0)
                    {
                        Console.WriteLine($"Bought {gameBought}");
                        Console.WriteLine("Out of money!"); return;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        currentBalance += productPrice;
                    }

                }

                gameBought = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");

        }
    }
}
