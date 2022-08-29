using System;
using System.Linq;
using System.Security.Principal;

namespace T02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
            

        }

        private static int VowelsCount(string word)
        {
            int vowelsCount = 0;
            
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' 
                    || word[i] == 'A' || word[i] == 'E' || word[i] == 'I'|| word[i] == 'O' || word[i] == 'U')
                {
                    vowelsCount++;

                }
            }

            return vowelsCount;
        }
    }
}
