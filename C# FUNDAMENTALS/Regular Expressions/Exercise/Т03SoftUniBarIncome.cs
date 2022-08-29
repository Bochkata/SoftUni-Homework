using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Т03SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<person>[A-Z][a-z]+)%[^|$%.]*<(?<products>\w+)>[^|$%.]*\|(?<quantity>[0-9]+)\|[^|$%.\d]*(?<price>\d+[.]?\d*)\$";

            string input = Console.ReadLine();
            
            double totalIncome = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string currentName = match.Groups["person"].Value + ":" + " ";
                    string currentProduct = match.Groups["products"].Value;
                    string currentNameAndProduct = currentName + currentProduct;
                    int currentQuantity = int.Parse(match.Groups["quantity"].Value);
                    double currentPrice = double.Parse(match.Groups["price"].Value);
                    double currentTotalCost = currentPrice * currentQuantity;
                    totalIncome += currentTotalCost;

                    Console.WriteLine($"{currentNameAndProduct} - {currentTotalCost:f2}");

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");

        }

    }
}
