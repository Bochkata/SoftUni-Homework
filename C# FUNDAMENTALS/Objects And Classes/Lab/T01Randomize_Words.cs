using System;

namespace T01Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries);

            Random randomWords = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomPosition = randomWords.Next(words.Length);

                string tempWord = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = tempWord;

            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
