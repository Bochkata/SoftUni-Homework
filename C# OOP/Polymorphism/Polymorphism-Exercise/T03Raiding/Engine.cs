
using System;
using System.Collections.Generic;
using System.Linq;
using T03Raiding.Models;

namespace T03Raiding
{
    public class Engine
    {
        public int ValidHeroes { get; set; }
        public void Run()
        {
            ValidHeroes = int.Parse(Console.ReadLine());
            int countOfValidHeroes = 0;
            List<BaseHero> raidGroup = new List<BaseHero>();

            while (countOfValidHeroes < ValidHeroes)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                BaseHero hero = null;
                try
                {
                    TypeHero result = Castable(heroType);
                    if (result == TypeHero.Druid)
                    {
                        hero = new Druid(heroName);

                    }
                    else if (result == TypeHero.Paladin)
                    {
                        hero = new Paladin(heroName);

                    }
                    else if (result == TypeHero.Rogue)
                    {
                        hero = new Rogue(heroName);

                    }
                    else if (result == TypeHero.Warrior)
                    {
                        hero = new Warrior(heroName);
                    }

                    countOfValidHeroes++;
                    raidGroup.Add(hero);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (BaseHero hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int bossPower = int.Parse(Console.ReadLine());
            if (bossPower <= raidGroup.Sum(x => x.Power))
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }

        private static TypeHero Castable(string typeHero)
        {
            bool isCastable = Enum.TryParse(typeHero, out TypeHero castable);
            if (!isCastable)
            {
                throw new ArgumentException("Invalid hero!");
            }

            return castable;
        }
    }
}
