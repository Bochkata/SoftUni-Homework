using System;
using System.Collections.Generic;

namespace Shapes
{

    public class StartUp
    {
        static void Main(string[] args)
        {

            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(new Circle(7));
            shapes.Add(new Square(7));
            shapes.Add(new Rectangle(10, 5));
            shapes.Add(new Square(9));
            shapes.Add(new Circle(9));
            shapes.Add(new Circle(15));
            foreach (IDrawable shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                shape.DrawShape();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}

