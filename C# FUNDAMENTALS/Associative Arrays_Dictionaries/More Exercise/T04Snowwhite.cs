using System;
using System.Collections.Generic;

using System.Linq;



namespace T04Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            Dictionary<string, int> allDwarfs_Hats_Physics = new Dictionary<string, int>();


            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] commands = input.Split(" <:> ");
                string currentDwarfName = commands[0];
                string currentDwarfHat = commands[1];
                int currentDwarfPhysics = int.Parse(commands[2]);

                string currentDwarf_Hat = $"{currentDwarfName} : {currentDwarfHat}";
                

                if (!allDwarfs_Hats_Physics.ContainsKey(currentDwarf_Hat))
                {
                    allDwarfs_Hats_Physics.Add(currentDwarf_Hat, currentDwarfPhysics);
                }
                else
                {
                    if (allDwarfs_Hats_Physics[currentDwarf_Hat] < currentDwarfPhysics)
                    {
                        allDwarfs_Hats_Physics[currentDwarf_Hat] = currentDwarfPhysics;
                    }
                }

            }

            allDwarfs_Hats_Physics = allDwarfs_Hats_Physics.OrderByDescending(x => x.Value)
                .ThenByDescending(a=>
                    allDwarfs_Hats_Physics.Where(b => b.Key.Split(" : ")[1] == a.Key.Split(" : ")[1]).Count())
                .ToDictionary(a => a.Key, v => v.Value);

            
            foreach (KeyValuePair<string, int> dwarfHat in allDwarfs_Hats_Physics)
            {
                Console.WriteLine($"({dwarfHat.Key.Split(" : ")[1]}) {dwarfHat.Key.Split(" : ")[0]} <-> {dwarfHat.Value}");
            }

        }
    }
}

