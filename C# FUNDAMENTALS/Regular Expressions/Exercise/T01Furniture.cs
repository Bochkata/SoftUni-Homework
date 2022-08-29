using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace T01Furniture
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            List<string> allFurnitures = new List<string>();
            double totalPrice = 0;

            while (input != "Purchase")
            {
                string pattern = @">>(?<furniture>[A-z\s]+)<<(?<price>[0-9]+[.]?[0-9]*)!(?<quantity>\d+)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string furnitureType = match.Groups["furniture"].Value;
                    double pricePerItem = double.Parse(match.Groups["price"].Value);
                    int furnitureCount = int.Parse(match.Groups["quantity"].Value);
                    allFurnitures.Add(furnitureType);

                    totalPrice += furnitureCount * pricePerItem;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (allFurnitures.Count > 0)
            {
                Console.WriteLine(string.Join("\n", allFurnitures));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");


        }
    }
}
