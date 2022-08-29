using System;

namespace T10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var integer = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{integer} X {i} = {integer * i}");
            //}
            int a = 1;
            var integer = int.Parse(Console.ReadLine());
            do
            {

                Console.WriteLine($"{integer} X {a} = {integer * a }");
                a++;
            } while (a <= 10);

        }
    }
}
