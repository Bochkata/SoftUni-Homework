using System;

namespace T07ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimeter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", name1, delimeter, name2);
        }
    }
}
