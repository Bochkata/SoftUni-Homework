using System;
using System.Linq;

namespace T02CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            
            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    leftRacerTime *= 0.80;
                }
                leftRacerTime += numbers[i];

            }

            for (int i = numbers.Length-1; i >= numbers.Length / 2 +1; i--)
            {
                if (numbers[i] == 0)
                {
                    rightRacerTime *= 0.80;
                }
                rightRacerTime += numbers[i];
                
            }

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }





        }
    }
}
