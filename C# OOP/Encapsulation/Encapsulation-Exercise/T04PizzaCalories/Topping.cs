using System;
using System.Collections.Generic;


namespace Restaurant
{
    public class Topping
    {
        private double weight;
        private const int baseCalories = 2;
        private string type;

        private Dictionary<string, double> toppings_Modifiers = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9},

        };
        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public string Type
        {
            get { return type; }
            private set
            {
                if (!toppings_Modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Calories => baseCalories *  weight * toppings_Modifiers[type.ToLower()];

    }
}
