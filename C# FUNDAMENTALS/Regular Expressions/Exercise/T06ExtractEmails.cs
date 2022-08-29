using System;
using System.Text.RegularExpressions;

namespace T06ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|\s)[A-Za-z0-9]+[A-Za-z0-9\.\-]+@[A-Za-z]+[A-Za-z-]?(\.|\-)[A-Za-z]+(\.[A-Za-z]+)*";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchEmail = regex.Matches(input);
            foreach (Match item in matchEmail)
            {
                Console.WriteLine(item.Value);
            }
            
        }
    }
}
