using System;


namespace T01DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string number = Console.ReadLine();
            DataTypes(input, number);

        }

        static void DataTypes(string input, string number)
        {

            if (input == "int")
            {
                Console.WriteLine(int.Parse(number)*2);
            }
            else if (input == "real")
            {
                Console.WriteLine($"{double.Parse(number)*1.5:f2}");
            }
            else
            {
                Console.WriteLine($"${number}$");
            }
          
        }

    }
}
