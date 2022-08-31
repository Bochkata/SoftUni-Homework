using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Sandwich : SandwichPrototype
    {
        private string meat;
        private string bread;
        private string cheese;
        private string veggies;


        public Sandwich(string meat, string bread, string cheese, string veggies, Test test)
        {
            this.meat = meat;
            this.bread = bread;
            this.cheese = cheese;
            this.veggies = veggies;
            this.Test = test;
        }

        public Test Test;

        public override Sandwich ShallowCopy() => this.MemberwiseClone() as Sandwich;

        public override Sandwich DeepCopy()
        {
            Sandwich copy = MemberwiseClone() as Sandwich;
            copy.meat = new string(meat);
            copy.meat = new string(bread);
            copy.meat = new string(cheese);
            copy.meat = new string(veggies);
            copy.Test = new Test(copy.Test.Integer);
            return copy;
        }
    }

    public class Test
        {
            public Test(int integer)
            {
                Integer = integer;
            }

            public int Integer { get; set; }
        }
    }

