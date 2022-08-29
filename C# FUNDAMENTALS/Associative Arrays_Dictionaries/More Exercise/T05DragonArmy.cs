using System;
using System.Collections.Generic;
using System.Linq;



namespace T05DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<double>>> allTypes_Dragons_Stats =
                new Dictionary<string, Dictionary<string, List<double>>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentType = input[0];
                string currentDragonName = input[1];
                double defaultDamage = 45;
                double defaultHealth = 250;
                double defaultArmor = 10;

                double damage;
                double health;
                double armor;


                double currentDamage = double.TryParse(input[2], out damage) ? damage : defaultDamage;
                double currentHealth = double.TryParse(input[3], out health) ? health : defaultHealth;
                double currentArmor = double.TryParse(input[4], out armor) ? armor : defaultArmor;

                if (!allTypes_Dragons_Stats.ContainsKey(currentType))
                {
                    allTypes_Dragons_Stats.Add(currentType, new Dictionary<string, List<double>>());
                }

                if (!allTypes_Dragons_Stats[currentType].ContainsKey(currentDragonName))
                {
                    allTypes_Dragons_Stats[currentType].Add(currentDragonName, new List<double>());
                    allTypes_Dragons_Stats[currentType][currentDragonName].Add(currentDamage);
                    allTypes_Dragons_Stats[currentType][currentDragonName].Add(currentHealth);
                    allTypes_Dragons_Stats[currentType][currentDragonName].Add(currentArmor);
                }
                allTypes_Dragons_Stats[currentType][currentDragonName].Clear();
                allTypes_Dragons_Stats[currentType][currentDragonName].Add(currentDamage);
                allTypes_Dragons_Stats[currentType][currentDragonName].Add(currentHealth);
                allTypes_Dragons_Stats[currentType][currentDragonName].Add(currentArmor);

            }
            
            int numberOfDragons = 0;

            foreach (KeyValuePair<string, Dictionary<string, List<double>>> dragonType in allTypes_Dragons_Stats)
            {
                List<double> stats = new List<double>();
                double totalDamagePerType = 0;
                double totalHealthPerType = 0;
                double totalArmorpPerType = 0;
                numberOfDragons = 0;
                foreach (KeyValuePair<string, List<double>> dragon in dragonType.Value.OrderBy(x => x.Key))
                {

                    numberOfDragons++;
                    totalDamagePerType += dragon.Value[0];
                    totalHealthPerType += dragon.Value[1];
                    totalArmorpPerType += dragon.Value[2];

                }
                stats.Add(totalDamagePerType / numberOfDragons);
                stats.Add(totalHealthPerType / numberOfDragons);
                stats.Add(totalArmorpPerType / numberOfDragons);
                Console.WriteLine($"{dragonType.Key}::({stats[0]:f2}/{stats[1]:f2}/{stats[2]:f2})");
                foreach (KeyValuePair<string, List<double>> dragon in dragonType.Value.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }


        }
    }
}
