using System;

namespace T06ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            switch (countryName)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");break;
                case "Argentina":
                case "Mexico":
                case "Spain":
                    Console.WriteLine("Spanish");break;
                                    default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
