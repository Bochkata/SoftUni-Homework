using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();
            string patternOfNames = @"[A-Za-z]";
            string patternOfDistance = @"[0-9]";
            Regex regexNames = new Regex(patternOfNames);
            Regex regexDistance = new Regex(patternOfDistance);

            Dictionary<string, int> allNames_TotalDistances = new Dictionary<string, int>();
           
            while (input != "end of race")
            {
                MatchCollection inputNames = regexNames.Matches(input);
                MatchCollection inputDistance = regexDistance.Matches(input);
                string currentName = String.Empty;
                int currentDistance = 0;

                //string[] allSymbols = inputNames.Cast<Match>().Select(x => x.Value).ToArray();
                //foreach (string symbol in allSymbols)
                //{
                //    currentName += symbol;
                //}
                foreach (Match letter in inputNames)
                {
                    currentName += letter.Value;
                }

                foreach (Match distance in inputDistance)
                {
                    currentDistance += int.Parse(distance.Value);
                }
                
                
                if (names.Contains(currentName))
                {
                    if (!allNames_TotalDistances.ContainsKey(currentName))
                    {
                        allNames_TotalDistances.Add(currentName, 0);
                    }
                    
                    allNames_TotalDistances[currentName] += currentDistance;
                }

                
                input = Console.ReadLine();
            }

            allNames_TotalDistances = allNames_TotalDistances.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);

            
                Console.WriteLine($"1st place: {allNames_TotalDistances.Keys.ElementAt(0)}");
                Console.WriteLine($"2nd place: {allNames_TotalDistances.Keys.ElementAt(1)}");
                Console.WriteLine($"3rd place: {allNames_TotalDistances.Keys.ElementAt(2)}");
                
               
            
        }
    }
}
