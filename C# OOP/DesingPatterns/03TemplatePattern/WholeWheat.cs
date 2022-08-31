using System;
using System.Collections.Generic;
using System.Text;

namespace _03TemplatePattern
{
   public class WholeWheat: Bread
    {
        public override void Mix()
        {
            Console.WriteLine("Mixing wholewheat");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking wholewheat 30 min");
        }
    }
}
