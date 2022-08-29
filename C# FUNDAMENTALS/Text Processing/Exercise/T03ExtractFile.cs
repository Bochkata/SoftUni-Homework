using System;
using System.Linq;

namespace T03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] path = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string fileNameAndExtension = path.Last();

            string[] array = fileNameAndExtension.Split(".").ToArray();
            string fileName = array[0];
            string extension = array[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");




        }
    }
}
