using System;
using System.Collections.Generic;

namespace T01CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    continue;
                }
                else
                {
                    if (!result.ContainsKey(word[i]))
                    {
                        result[word[i]] = 0;
                    }

                    result[word[i]]++;
                }
            }

            foreach (KeyValuePair<char,int> item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
                
            }
        }
    }
}

