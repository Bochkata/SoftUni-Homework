using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace T04StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> allAttacked_Destroyed_Planets = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();
                string pattern =
                    @"@(?<planet>[A-z]+)[^@,\-!:.]*:(?<population>[0-9]+)[^@,\-!:.]*!(?<AttackOrDestroy>[A|D])![^@,\-!:.]*->(?<soldierCount>[0-9]+)";

                int decreaseNumber = input.ToUpper().Count(x => x == 'S' || x == 'T' || x == 'A' || x == 'R');


                string decryptedMessage = string.Empty;
                for (int j = 0; j < input.Length; j++)
                {
                    decryptedMessage += (char)(input[j] - decreaseNumber);
                }

                MatchCollection matches = Regex.Matches(decryptedMessage, pattern);
                
                foreach (Match match in matches)
                {
                    string planetName = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string AttackOrDestruction = match.Groups["AttackOrDestroy"].Value;
                    int soldiersCount = int.Parse(match.Groups["soldierCount"].Value);

                    if (!allAttacked_Destroyed_Planets.ContainsKey(AttackOrDestruction))
                    {
                        allAttacked_Destroyed_Planets.Add(AttackOrDestruction, new List<string>());
                    }

                    allAttacked_Destroyed_Planets[AttackOrDestruction].Add(planetName);
                    
                }

            }
            

            if (allAttacked_Destroyed_Planets.ContainsKey("A"))
            {

                Console.WriteLine($"Attacked planets: {allAttacked_Destroyed_Planets["A"].Count}");
                Console.WriteLine($"-> {string.Join("\n-> ", allAttacked_Destroyed_Planets["A"].OrderBy(x=>x))}");
            }
            else if (!allAttacked_Destroyed_Planets.ContainsKey("A"))
            {
                Console.WriteLine("Attacked planets: 0");
            }

            if (allAttacked_Destroyed_Planets.ContainsKey("D"))
            {

                Console.WriteLine($"Destroyed planets: {allAttacked_Destroyed_Planets["D"].Count}");
                Console.WriteLine($"-> {string.Join("\n-> ", allAttacked_Destroyed_Planets["D"].OrderBy(x=>x))}");
            }
            else if (!allAttacked_Destroyed_Planets.ContainsKey("D"))
            {
                Console.WriteLine("Destroyed planets: 0");
            }


        }
    }
}
