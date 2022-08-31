using System;

namespace Shapes
{
   public  class Circle : IDrawable
   {
       private int radius;
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public void Draw()
        {
            for (int i = 0; i < this.Radius * 2; i++)
            {
                for (int j = 0; j < this.Radius * 2; j++)
                {
                    double distance = Math.Sqrt((this.Radius - i) * (this.Radius - i) + (this.Radius - j) * (this.Radius - j));
                    if (Math.Ceiling(distance) < this.Radius)
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }

        public void DrawShape()
        {
            for (int i = 0; i < this.Radius * 2; i++)
            {
                for (int j = 0; j < this.Radius * 2; j++)
                {
                    double distance = Math.Sqrt((this.Radius - i) * (this.Radius - i) + (this.Radius - j) * (this.Radius - j));
                    if (Math.Ceiling(distance) == this.Radius - 1)
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }
        //public void DrawShape()
        //{
        //    double rIn = this.Radius - 0.4;
        //    double rOut = this.Radius + 0.4;
        //    for (double y = this.Radius; y >= -this.Radius; --y)
        //    {
        //        for (double x = -this.Radius; x < rOut; x += 0.5)
        //        {
        //            double value = x * x + y * y;
        //            if (value >= rIn * rIn && value <= rOut * rOut)
        //            {
        //                Console.Write("*");
        //            }
        //            else
        //            {
        //                Console.Write(" ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }

        //}

        public override string ToString()
        {
            return "Circle with radius " + this.Radius;
        }
    }
}
