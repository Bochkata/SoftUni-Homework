using System;
using System.Text.RegularExpressions;

namespace T01WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"(\@{6,})|(\#{6,})|(\${6,})|(\^{6,})";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length == 20)
                {
                    string leftSide = input[i].Substring(0, 10);
                    string rightSide = input[i].Substring(10);

                    Match matchLeftSide = regex.Match(leftSide);
                    Match matchRightSide = regex.Match(rightSide);
                    if (matchLeftSide.Success && matchRightSide.Success)
                    {

                        int minMatch = Math.Min(matchLeftSide.Length, matchRightSide.Length);
                        string leftPart = matchLeftSide.Value.Substring(0, minMatch);
                        string rightPart = matchRightSide.Value.Substring(0, minMatch);
                        if (minMatch == 10)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {minMatch}{leftPart[0]} Jackpot!");
                        }
                        else if (leftPart == rightPart && minMatch < 10)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {minMatch}{leftPart[0]}");
                        }
                        
                    }
                    else if (!matchLeftSide.Success || !matchRightSide.Success)
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }

            
        }
    }
}
