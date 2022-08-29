using System;

namespace T03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();

            string input = Console.ReadLine();


            while (input.Contains(wordToRemove))
            {

                for (int i = 0; i < input.Length; i++)
                {
                    input = input.Replace(wordToRemove, "");
                }

            }

            Console.WriteLine(input);

            //int indexOfWordToRemove = input.IndexOf(wordToRemove);

            //while (indexOfWordToRemove != -1)
            //{

            //    input = input.Remove(indexOfWordToRemove, wordToRemove.Length);
            //    indexOfWordToRemove = input.IndexOf(wordToRemove);


            //}

            //    Console.WriteLine(input);
        }
    }
}
