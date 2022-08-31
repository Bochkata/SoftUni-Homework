using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Add(int a, int b)");
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            Console.WriteLine("Add(double a, double b, double c)");
            return a + b + c;
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            Console.WriteLine("Add(decimal a, decimal b, decimal c)");
            return a + b + c;
        }
    }
}
