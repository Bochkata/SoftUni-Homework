using System;

namespace T04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                int index = text.IndexOf(bannedWords[i]);

                for (int j = 0; j < text.Length; j++)
            {
                string textToRemove = bannedWords[i];

                text = text.Remove(index, bannedWords[i].Length);
                text = text.Insert(index, new string('*', bannedWords[i].Length));
                index = text.IndexOf(bannedWords[i]);
                if (index == -1)
                {
                    break;
                }
            }

        }

        //for (int i = 0; i < bannedWords.Length; i++)
        //{
        //    text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
        //}



        Console.WriteLine(text);

            

            


        }
    }
}
