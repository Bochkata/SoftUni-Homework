using System;



namespace T01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            while (input != "end")
            {
                char[] word = input.ToCharArray();
                char[] reversedWord = new char[word.Length];
                int reversedInputIndex = word.Length - 1;
                for (int i = 0; i < word.Length; i++)
                {
                    
                    reversedWord[reversedInputIndex] = word[i];
                    reversedInputIndex -=1;

                }

                Console.WriteLine($"{String.Join("", word)} = {String.Join("", reversedWord)}");
                input = Console.ReadLine();
            }

        }
    }
}
