using System;

namespace T11RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            decimal volume = (decimal)(length * width * height / 3);
            Console.Write("Pyramid Volume: {0:f2}", volume);

            

        }
    }
}
