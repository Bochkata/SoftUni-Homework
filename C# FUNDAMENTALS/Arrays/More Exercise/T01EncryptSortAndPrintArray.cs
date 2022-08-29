using System;

namespace T01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfWords];
            int indexOfArray = 0;

            while (numberOfWords > 0)
            {
                string name = Console.ReadLine();
                numberOfWords--;
                string vowels = "aAeEiIoOuU";
               
                int sumVowels = 0;
                int sumConsonant = 0;
                int sumVowelsAndConsonants;


                for (int i = 0; i < name.Length; i++)
                {
                    if (vowels.Contains(name[i]))
                    {
                        sumVowels += (int)(char)name[i] * name.Length;
                    }

                    else 

                    {
                        sumConsonant += (int)(char)name[i] / name.Length;
                    }
                }



                sumVowelsAndConsonants = sumVowels + sumConsonant;

                array[indexOfArray] = sumVowelsAndConsonants;
                indexOfArray++;

            }


            Array.Sort(array);

            Console.WriteLine(string.Join("\n", array));

        }
    }
}
