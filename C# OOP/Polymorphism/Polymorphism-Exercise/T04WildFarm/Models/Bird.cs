
using System;

namespace T04WildFarm.Models
{
    public abstract class Bird : Animal, IAnimal
    {
        private double wingSize;
        protected Bird(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten)
        {
            WingSize = wingSize;
        }

        public double WingSize
        {
            get
            {
                return wingSize;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                wingSize = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
