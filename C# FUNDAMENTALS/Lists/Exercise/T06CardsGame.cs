using System;
using System.Collections.Generic;

using System.Linq;

namespace T06CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();



            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {

                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(secondPlayerCards[0]);
                    firstPlayerCards.Add(firstPlayerCards[0]);

                }
                else if (firstPlayerCards[0] < secondPlayerCards[0])
                {
                    secondPlayerCards.Add(firstPlayerCards[0]);
                    secondPlayerCards.Add(secondPlayerCards[0]);

                }

                firstPlayerCards.Remove(firstPlayerCards[0]);
                secondPlayerCards.Remove(secondPlayerCards[0]);


            }


            if (firstPlayerCards.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");

            }
            else if (secondPlayerCards.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
        }
    }
}
