using System;
using System.Collections.Generic;
using System.Linq;

namespace T04SnowwhiteVer2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> allHats_Dwarves_Physics = new Dictionary<string, int>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = input.Split(" <:> ");

                string currentDwarfName = tokens[0];
                string currentHatColor = tokens[1];
                int currentDwarfPhysics = int.Parse(tokens[2]);

                string currentDictKey = $"{currentHatColor} {currentDwarfName}";

                if (!allHats_Dwarves_Physics.ContainsKey(currentDictKey))
                {
                    allHats_Dwarves_Physics.Add(currentDictKey, 0);
                }

                if (allHats_Dwarves_Physics[currentDictKey] < currentDwarfPhysics)
                {
                    allHats_Dwarves_Physics[currentDictKey] = currentDwarfPhysics;
                }

            }

            foreach (KeyValuePair<string, int> hatColor_Name in allHats_Dwarves_Physics.OrderByDescending(v => v.Value).ThenByDescending(k => allHats_Dwarves_Physics.Where(a => a.Key.Split(" ")[0] == k.Key.Split(" ")[0]).Count()))

            {
                Console.WriteLine($"({hatColor_Name.Key.Split(" ")[0]}) {hatColor_Name.Key.Split(" ")[1]} <-> {hatColor_Name.Value}");
            }


        }
    }
}
