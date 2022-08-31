

using System;
using System.Collections.Generic;
using System.Linq;


namespace Restaurant
{
    public class Pizza
    {

        private string name;
        private Dough dough;
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;

        }

        public int countOfToppings => toppings.Count;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public IReadOnlyCollection<Topping> Toppings  => toppings.AsReadOnly(); 

        public double PizzaCalories => dough.Calories + toppings.Sum(x => x.Calories);

        public void AddTopping(Topping topping)
        {
            if (countOfToppings == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);

        }

    }
}
