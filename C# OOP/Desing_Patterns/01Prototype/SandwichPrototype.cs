using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class SandwichPrototype
    {
        public abstract Sandwich ShallowCopy();
        public abstract Sandwich DeepCopy();


    }
}
