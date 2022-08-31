using System;
using System.Collections.Generic;
using System.Text;

namespace _03TemplatePattern
{
   public class Sourdough: Bread
    {
        public override void Mix()
        {
            Console.WriteLine("Mixing sourdough");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking sourdough 60 min");
        }
    }
}
