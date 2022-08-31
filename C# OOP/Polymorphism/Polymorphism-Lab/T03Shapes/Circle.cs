﻿
using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
       

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
