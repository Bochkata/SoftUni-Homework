

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return width;}
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public override double CalculatePerimeter()
        {
            return 2 * width + 2 * height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
