using System;

namespace _03TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread sourdough = new Sourdough();
            Bread wholewheat = new WholeWheat();

            sourdough.Make();
            wholewheat.Make();

            Console.WriteLine("Done");
        }
    }
}
