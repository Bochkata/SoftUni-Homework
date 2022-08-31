using System;



namespace Shapes
{
    public  class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            private set { height = value; }
        }
        
        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                Console.WriteLine(new string('*', this.Width * 2));
            }
        }

        public void DrawShape()
        {
            Console.WriteLine(new string('*', this.Width * 2));
            for (int i = 0; i < this.Height - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', this.Width * 2 - 2) + "*");
            }

            Console.WriteLine(new string('*', this.Width * 2));
        }
        //public void DrawShape()
        //{

        //        Draw(this.Width, '*', '*');
        //        for (int i = 1; i < this.Height - 1; ++i)
        //        {
        //            Draw(this.Width, '*', ' ');
        //        }

        //        Draw(this.Width, '*', '*');
        
        //}
        //public void Draw(int width, char end, char mid) //draw a line
        //{
        //    Console.Write(end);
        //    for (int i = 1; i < width - 1; ++i)
        //    {
        //        Console.Write(mid);
        //    }

        //    Console.WriteLine(end);
        //}
        
        public override string ToString()
        {
            return $"Rectangle with width {this.Width} and height {this.Height}";
        }
    }
}
