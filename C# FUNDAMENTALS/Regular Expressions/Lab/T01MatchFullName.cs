using System;
using System.Text.RegularExpressions;



namespace T01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection collection = Regex.Matches(input, regex);

            foreach (Match item in collection)
            {
                Console.Write(item.Value + " ");
            }

            Console.WriteLine();

        }

    }
}
