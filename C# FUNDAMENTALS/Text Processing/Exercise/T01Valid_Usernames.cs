using System;

namespace T01Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            char hyphon = '-';
            char underscore = '_';


            for (int i = 0; i < input.Length; i++)
            {

                int countOfSymbols = 0;
                for (int j = 0; j < input[i].Length; j++)
                {

                    if (char.IsLetterOrDigit(input[i][j]) || input[i][j] == hyphon || input[i][j] == underscore)
                    {
                        countOfSymbols++;
                    }

                }

                if (countOfSymbols == input[i].Length && input[i].Length >= 3 && input[i].Length <= 16)
                {

                    Console.WriteLine(input[i]);
                }


            }

        }
    }
}
