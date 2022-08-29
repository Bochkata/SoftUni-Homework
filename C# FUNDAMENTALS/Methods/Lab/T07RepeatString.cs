using System;
using System.Linq;
using System.Text;

namespace T07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            string newWord = RepeatedWord(word, repeat);
            Console.WriteLine(newWord);

            //    string word = Console.ReadLine();
            //    int repeat = int.Parse(Console.ReadLine());
            //    RepeatedWord(word, repeat);
            //}

            //static void RepeatedWord(string word, int number)
            //{

            //    for (int i = 0; i < number; i++)
            //    {
            //        Console.Write($"{word}");

            //    }
        }

        static string RepeatedWord(string word, int number)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                result.Append($"{word}");
            }

            return result.ToString();

        }
    }
}
