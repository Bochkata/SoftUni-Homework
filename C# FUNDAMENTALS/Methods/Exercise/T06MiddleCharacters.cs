using System;

namespace T06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleLetters(input);

        }

        static void MiddleLetters(string word)
        {
           
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine($"{word[word.Length/2-1]}{word[word.Length/2]}");
                
                }
                else
                {
                    Console.WriteLine($"{word[word.Length/2]}");
                }
            }
    
    }
}
