using System;

namespace T03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            CharacterBetween(symbol1, symbol2);
        }

        static void CharacterBetween(char char1, char char2)
        {
            if (char1 < char2)
            {
                for (int i = char1 + 1; i < char2; i++)
                {

                    Console.Write($"{(char)i} ");

                }
            }
            else if (char2 < char1)
            {
                for (int i = char2 + 1; i < char1; i++)
                {
                    Console.Write($"{(char)i} ");
                }

            }
            
        }
    }
}
