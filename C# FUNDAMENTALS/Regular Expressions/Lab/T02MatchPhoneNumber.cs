using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\s*\+\b359\b(\s|-)\b2\b\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();
            Regex pattern = new Regex(regex);

            MatchCollection matches = pattern.Matches(input);

            string[] array = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

           
            Console.WriteLine(String.Join(", ", array));

           




        }
    }
}
