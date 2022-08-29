using System;
using System.Threading.Channels;

namespace T02VowelsCountVer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelsCount(input);
        }

        static void VowelsCount(string word)
        {
            int count = 0;
            
            foreach (char vowels in word)
            {
                if ("aeiou".Contains(vowels))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

    }
}
