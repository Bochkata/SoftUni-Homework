using System;

namespace T02CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[] word1 = input[0].ToCharArray();
            char[] word2 = input[1].ToCharArray();

            char[] longerWord = word1.Length > word2.Length ? word1 : word2;
            char[] shorterWord = word1.Length >= word2.Length ? word2 : word1;
            
            int result = 0;
           
            for (int i = 0; i < shorterWord.Length; i++)
            {
               result += word1[i] * word2[i];
                
            }

            int difference = longerWord.Length - shorterWord.Length;
            if (difference > 0)
            {
                for (int k = shorterWord.Length; k < longerWord.Length; k++)
                {
                    result += longerWord[k];
                   
                }
            }

            Console.WriteLine(result);
        }

    }
}

