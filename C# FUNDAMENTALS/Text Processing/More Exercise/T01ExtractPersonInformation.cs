using System;


using System.Linq;

namespace T01ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();

                int startNameIndex = input.IndexOf('@')+1;
                int endNameIndex = input.IndexOf('|')-1;
                string name = input.Substring(startNameIndex, endNameIndex - startNameIndex+1);
                //string name = input[startNameIndex..^(input.Length -1 - endNameIndex)];

                int startAgeIndex = input.IndexOf('#')+1;
                int endIndexOfAge = input.IndexOf('*')-1;
                string age = input.Substring(startAgeIndex, endIndexOfAge - startAgeIndex + 1);
                //string age = input[startAgeIndex..^(input.Length - 1 - endIndexOfAge)];
                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}
