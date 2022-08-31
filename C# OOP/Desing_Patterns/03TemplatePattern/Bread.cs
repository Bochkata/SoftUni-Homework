using System;
using System.Collections.Generic;
using System.Text;

namespace _03TemplatePattern
{
    public abstract class Bread
    {
        public abstract void Mix();
        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine($"Slicing {this.GetType().Name}");
        }

        public void Make()
        {
            Mix();
            Bake();
            Slice();
        }

    }
}
