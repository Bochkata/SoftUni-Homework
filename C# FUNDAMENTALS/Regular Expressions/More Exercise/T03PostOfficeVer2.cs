using System;
using System.Text.RegularExpressions;

namespace T03PostOfficeVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            string patternCapitalLetters = @"([#$*&])([A-Z]+)(\1)";
            Regex regexCapitalLetter = new Regex(patternCapitalLetters);
            Match capitalLetters = regexCapitalLetter.Match(input[0]);

            string allCapitalLetters = capitalLetters.Groups[2].Value;

            for (int i = 0; i < allCapitalLetters.Length; i++)
            {
                int capLetterASCII = allCapitalLetters[i];

                string patternCapASCIIWordLength = $@"{capLetterASCII}:(?<length>[0-9][0-9])";
                Regex regexCapASCIIWordlength = new Regex(patternCapASCIIWordLength);
                Match asciiCapLetWordLength = regexCapASCIIWordlength.Match(input[1]);

                int wordLength = int.Parse(asciiCapLetWordLength.Groups["length"].Value);

                string patternWords = $@"(?<=\s|^)({allCapitalLetters[i]}[^\s]{{{wordLength}}})(?=\s|$)";
                Regex regexWords = new Regex(patternWords);
                Match word = regexWords.Match(input[2]);

                string result = word.Groups[1].Value;
                Console.WriteLine(result);

            }
            
        }
    }
}
