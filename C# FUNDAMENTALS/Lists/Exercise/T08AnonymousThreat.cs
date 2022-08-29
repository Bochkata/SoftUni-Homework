using System;
using System.Collections.Generic;

using System.Linq;



namespace T08AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


            while (commands[0] != "3:1")
            {

                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                string newWord = "";
                if (startIndex < 0 || startIndex >= input.Count)
                {
                    startIndex = 0;
                }

                if (endIndex >= input.Count)
                {
                    endIndex = input.Count - 1;
                }


                if (commands[0] == "merge")
                {


                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newWord += input[i];
                    }


                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, newWord);
                }


                if (commands[0] == "divide")
                {


                    int partitions = int.Parse(commands[2]);
                    List<string> newList = new List<string>();

                    string wordToDivide = input[startIndex];
                    int numberOfSymbolsInAPart = wordToDivide.Length / partitions;
                    input.Remove(wordToDivide);
                    int remainder = wordToDivide.Length % partitions;

                    for (int i = 0; i < wordToDivide.Length - numberOfSymbolsInAPart - remainder; i += numberOfSymbolsInAPart)
                    {

                        newList.Add(wordToDivide.Substring(i, numberOfSymbolsInAPart));


                    }
                    newList.Add(wordToDivide.Substring(wordToDivide.Length - numberOfSymbolsInAPart - remainder));


                    input.InsertRange(startIndex, newList);

                }


                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
