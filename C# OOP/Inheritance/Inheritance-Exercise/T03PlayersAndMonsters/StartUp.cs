using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Viktor", 15);

            Console.WriteLine(hero);

            DarkKnight one = new DarkKnight("Behlul", 18);

        }
    }
}