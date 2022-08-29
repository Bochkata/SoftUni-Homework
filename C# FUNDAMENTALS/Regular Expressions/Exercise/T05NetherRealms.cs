using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T05NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+\-,\/*.]";
            string damagePattern = @"[-]?[0-9]*[.]?[0-9]+";
            string mulptipliers_Dividers = @"[\*\/]";

            Regex regexHealth = new Regex(healthPattern);
            Regex regexDamage = new Regex(damagePattern);
            Regex regexMultipliers_Dividers = new Regex(mulptipliers_Dividers);

            string[] input = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection currentHealth = regexHealth.Matches(input[i]);
                MatchCollection currentDamage = regexDamage.Matches(input[i]);
                MatchCollection multipliersAndDividers = regexMultipliers_Dividers.Matches(input[i]);

                int health = 0;
                double damage = 0;

                foreach (Match item in currentHealth)
                {

                    health += char.Parse(item.Value);
                    
                }

                foreach (Match item in currentDamage)
                {
                    damage += double.Parse(item.Value);
                }

                foreach (Match item in multipliersAndDividers)
                {
                    if (item.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (item.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{input[i]} - {health} health, {damage:f2} damage");

            }
            

        }
    }
}
