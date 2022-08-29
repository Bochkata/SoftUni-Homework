using System;
using System.Linq;

namespace T07StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int bombRange = 0;
            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                  bombRange += int.Parse(input[i + 1].ToString());
                 
                }
                
                else if (bombRange > 0 && input[i] != '>')
                {

                    input = input.Remove(i, 1);
                    bombRange--;
                    i--;

                }

            }

            Console.WriteLine(input);
        }
    }
}
