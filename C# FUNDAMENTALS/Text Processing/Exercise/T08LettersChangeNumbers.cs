using System;



namespace T08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string subInput = input[i];

                char firstLetter = subInput[0];
                char lastletter = subInput[^1];
                double number = double.Parse(subInput[1..^1]);

                if (char.IsUpper(firstLetter))
                {
                    int letterPosition = firstLetter - 64;
                    sum += number / letterPosition;

                }
                else if (char.IsLower(firstLetter))
                {
                    int letterPosition = firstLetter - 96;
                    sum += number * letterPosition;
                }

                if (char.IsUpper((lastletter)))
                {
                    int letterPosition = lastletter - 64;
                    sum -= letterPosition;
                }
                else if (char.IsLower(lastletter))
                {
                    int letterPosition = lastletter - 96;
                    sum += letterPosition;
                }

            }

            Console.WriteLine($"{sum:f2}");

        }
    }
}
