using System;
using System.Collections.Generic;

namespace T03WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonyms.ContainsKey(word))
                {
                    synonyms[word].Add(synonym);
                }
                else
                {
                    synonyms.Add(word, new List<string>());
                    synonyms[word].Add(synonym);
                }
                //if (!synonyms.ContainsKey(word))
                //{
                //    synonyms[word] = new List<string>();
                //}
                //synonyms[word].Add(synonym);
            }

            foreach (KeyValuePair<string, List<string>> item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
