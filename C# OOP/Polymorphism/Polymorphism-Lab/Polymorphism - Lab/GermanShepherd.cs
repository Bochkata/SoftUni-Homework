using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class GermanShepherd : Dog
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Baaaaaaaaaaaaaaaaw....");
        }
    }
}
