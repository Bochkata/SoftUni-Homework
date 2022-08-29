using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace T05DragonArmyVer2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number = int.Parse(Console.ReadLine());

            List<Dragon> allDragons = new List<Dragon>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentType = input[0];
                string currentDragonName = input[1];
                double defaultDamage = 45;
                double defaultHealth = 250;
                double defaultArmor = 10;

                double damage = 0;
                double health = 0;
                double armor = 0;


                double currentDamage = double.TryParse(input[2], out damage) ? damage : defaultDamage;
                double currentHealth = double.TryParse(input[3], out health) ? health : defaultHealth;
                double currentArmor = double.TryParse(input[4], out armor) ? armor : defaultArmor;

                Dragon repetativeDragon =
                    allDragons.FirstOrDefault(x => x.Type == currentType && x.Name == currentDragonName);

                if(repetativeDragon == null)
                {
                    Dragon dragon = new Dragon();
                    {
                        dragon.Type = currentType;
                        dragon.Name = currentDragonName;
                        dragon.Damage = currentDamage;
                        dragon.Health = currentHealth;
                        dragon.Armor = currentArmor;
                    }
                    allDragons.Add(dragon);

                }
                else
                {
                    repetativeDragon.Damage = currentDamage;
                    repetativeDragon.Health = currentHealth;
                    repetativeDragon.Armor = currentArmor;
                    
                }
                

            }

            IEnumerable<IGrouping<string, Dragon>> grouped = allDragons.GroupBy(x => x.Type);
                 


            foreach (IGrouping<string, Dragon> type in grouped)
            {
                Console.WriteLine($"{type.Key}::({type.Average(x=>x.Damage):f2}/{type.Average(x=>x.Health):f2}/{type.Average(x=>x.Armor):f2})");
                foreach (var dragon in allDragons.OrderBy(x=>x.Name))
                {
                    if (type.Key == dragon.Type)
                    {
                        Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");

                    }
                }
            }

            
        }
        class Dragon
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public double Damage { get; set; }
            public double Health { get; set; }
            public double Armor { get; set; }
        }
    }
}
