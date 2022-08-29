using System;
using System.Data.Common;
using System.Text.RegularExpressions;


namespace T03MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string input = Console.ReadLine();
            
            MatchCollection matchDates = Regex.Matches(input, pattern);

            foreach (Match item in matchDates)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }

        }
    }
}
