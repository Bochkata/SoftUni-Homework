using System;
using System.Collections.Generic;
using System.Linq;


namespace T05DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal availableMoney = decimal.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            List<int> initialPrices = drumSet.Select(x => x * 3).ToList();

            string command = String.Empty;

            bool isFlag = false;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int decreasePower = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= decreasePower;
                    if (drumSet[i] <= 0)
                    {
                        availableMoney -= initialPrices[i];
                        if (availableMoney < 0)
                        {
                            availableMoney += initialPrices[i];
                            drumSet.Remove(drumSet[i]);
                            initialPrices.Remove(initialPrices[i]);
                            if (drumSet.Count == 0)
                            {
                                isFlag = true;
                                break;

                            }
                            i--;

                        }
                        else if (availableMoney == 0)
                        {
                            drumSet[i] = initialPrices[i] / 3;
                            isFlag = true;
                            break;
                        }
                        else
                        {
                            drumSet[i] = initialPrices[i] / 3;
                        }
                    }

                }

                if (isFlag)
                {
                    break;
                }

            }

            if (drumSet.Count > 0)
            {
                Console.WriteLine(string.Join(" ", drumSet));
            }

            Console.WriteLine($"Gabsy has {availableMoney:f2}lv.");
        }
    }
}
