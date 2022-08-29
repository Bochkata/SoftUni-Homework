using System;
using System.Linq;



namespace T03TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] decreaseNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                
            string input = Console.ReadLine();


            string searchedText = String.Empty;

            while (input != "find")
            {
                int index = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (index == decreaseNumbers.Length)
                    {
                        index = 0;

                    }

                    int temp = input[i] - decreaseNumbers[index++];
                    
                    char symbol = (char) temp;
                    searchedText += symbol;

                }
                
                int typeStartIndex = searchedText.IndexOf('&') + 1;
                int typeEndIndex = searchedText.LastIndexOf('&') - 1;
                int coordinatesStartIndex = searchedText.IndexOf('<') + 1;
                int coordinatesEndIndex = searchedText.LastIndexOf('>') - 1;
                string treasureType = searchedText[typeStartIndex..^(searchedText.Length-1-typeEndIndex)];
                string treasureCoordinates = searchedText[coordinatesStartIndex..^(searchedText.Length-1-coordinatesEndIndex)];
                Console.WriteLine($"Found {treasureType} at {treasureCoordinates}");
                searchedText = String.Empty;
                input = Console.ReadLine();
            }

            
        }
    }
}
