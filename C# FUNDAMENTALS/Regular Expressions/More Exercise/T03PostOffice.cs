using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.RegularExpressions;

namespace T03PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            string patternCapitalLetters = @"([#$*&])([A-Z]+)(\1)";
            string patternWordLength = @"(\d{2,3}):(\d{2})";
            string patternWords = @"\b([^\s]+)\b";

            //string patternWords = @"(?<=\s|^)([^\s]+)(?=\s|$)";
            

            Regex regexCapitalLetter = new Regex(patternCapitalLetters);
            Regex regexWordlength = new Regex(patternWordLength);
            Regex regexWords = new Regex(patternWords);


            Match capitalLetters = regexCapitalLetter.Match(input[0]);
            MatchCollection wordLen = regexWordlength.Matches(input[1]);
            MatchCollection words = regexWords.Matches(input[2]);

            
            
            string allCapitalLetters = capitalLetters.Value.Substring(1, capitalLetters.Length - 2);
            string[] wordCapLetterLength = wordLen.Cast<Match>().Select(x => x.Value).Distinct().ToArray();

            
                for (int i = 0; i < allCapitalLetters.Length; i++)
                {
                    for (int j = 0; j < wordCapLetterLength.Length; j++)
                    {
                        
                        if ((int)allCapitalLetters[i] == int.Parse(wordCapLetterLength[j].Substring(0,2)))

                        {
                            int length = int.Parse(wordCapLetterLength[j].Substring(3,2)) + 1;
                            foreach (Match word in words)
                            {
                                if (word.Groups[1].Value[0] == allCapitalLetters[i] && length == word.Length)
                                {
                                    Console.WriteLine(word.Value);
                                }
                            }
                        }
                    }
                }
                
        }
    }
}
