using System;

namespace DesignPatterns
{
    class Program
    {
        //PROTOTYPE PATTERN
        static void Main(string[] args)
        {
            Sandwich firstSandwich = new Sandwich(meat:"salami", bread:"white", cheese:"feta", veggies:"tomato", test:new Test(15));

            //Sandwich shallowCopy = firstSandwich.ShallowCopy();
            Sandwich deepCopy = firstSandwich.DeepCopy();
            //shallowCopy.Test.Integer = 20;
            deepCopy.Test.Integer = 35;

            Console.WriteLine($"{nameof(firstSandwich)} {firstSandwich.Test.Integer}");
            
           //Console.WriteLine($"{nameof(shallowCopy)} {shallowCopy.Test.Integer}");
           Console.WriteLine($"{nameof(deepCopy)} {deepCopy.Test.Integer}");
        }
    }
}
