using System;

namespace T11MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //var integer = int.Parse(Console.ReadLine());
            //var multiplier = int.Parse(Console.ReadLine());

            //for (int i = multiplier; i <= 10; i++)
            //{
            //    Console.WriteLine($"{integer} X {i} = {integer * i}");
            //}
            //if (multiplier > 10)
            //{
            //    Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
            //}


            var integer = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier }");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
