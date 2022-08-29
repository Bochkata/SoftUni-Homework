using System;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pat = @"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<message>[A-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pat);
                if (match.Success)
                {
                    bool flag = true;
                    string temp = match.Groups["command"].Value + ": ";
                    foreach (char item1 in match.Groups["message"].Value)
                    {

                        if (!char.IsLetter(item1))
                        {
                            flag = false;

                            break;
                        }
                        else
                        {
                            temp += (int)item1 + " ";
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine(temp);
                    }
                }

                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
