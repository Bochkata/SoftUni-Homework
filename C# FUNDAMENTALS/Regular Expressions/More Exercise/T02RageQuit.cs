using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T02RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(?<symbols>[\D]+)(?<number>[\d]+)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            StringBuilder finalWord = new StringBuilder();
            

            foreach (Match match in matches)
            {
                string symbols = match.Groups["symbols"].Value;
                string numbers = match.Groups["number"].Value;

                
                
                for (int i = 0; i < int.Parse(numbers); i++)
                {
                    finalWord.Append(symbols);
                }
                
            }

            string result = finalWord.ToString().ToUpper();

            int numberOfDistinctSymbols = result.ToUpper().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {numberOfDistinctSymbols}");
            Console.WriteLine(result);

        }
    }
}
