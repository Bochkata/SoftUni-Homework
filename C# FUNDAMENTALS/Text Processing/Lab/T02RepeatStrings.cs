using System;
using System.Text;

namespace T02RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            //string result = String.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sb.Append(array[i]);
                    //result += array[i];
                }
                
            }

            Console.WriteLine(sb);
        }
    }
}
