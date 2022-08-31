
using System;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double height;
        private double width;

        public Box(double length, double width, double height)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        private bool ParametersValidation(double value) => value <= 0;
        private double Length
        {

            //get =>  length; 


            set
            {
                if (ParametersValidation(value))
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }
        private double Width
        {

            //get { return width; }


           set
            {
                if (ParametersValidation(value))
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }
        private double Height
        {

            //get { return height; }


            set
            {
                if (ParametersValidation(value))
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }
      
        
        public double SurfaceArea()
        {
            return 2*(length * width + length * height + width * height);
        }
        public double LateralArea()
        {
            return (length * height + width * height) * 2;
        }
        public double Volume()
        {
            return length * width * height;
        }
    }


}
