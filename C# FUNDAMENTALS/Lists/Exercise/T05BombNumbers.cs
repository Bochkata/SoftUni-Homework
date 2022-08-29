using System;
using System.Collections.Generic;

using System.Linq;


namespace T05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> bombNumber = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bomb = bombNumber[0];
            int bombPower = bombNumber[1];

            for (int i = 0; i < numbers.Count; i++)
            {

                if (bomb == numbers[i])
                {

                    if (numbers.Count - 1 - i >= bombPower)
                    {
                        numbers.RemoveRange(i + 1, bombPower);

                    }
                    else if (numbers.Count - 1 - i < bombPower)
                    {
                        numbers.RemoveRange(i + 1, numbers.Count - 1 - i);
                    }
                }


            }

            for (int j = 0; j < numbers.Count; j++)
            {

                if (bomb == numbers[j])
                {
                    if (j >= bombPower)
                    {
                        numbers.RemoveRange(j - bombPower, bombPower + 1);
                        j = j - bombPower - 1;

                    }
                    else if (j < bombPower)
                    {
                        numbers.RemoveRange(0, j + 1);
                        j = -1;
                    }
                }
            }



            Console.WriteLine(numbers.Sum());
        }
    }
}
