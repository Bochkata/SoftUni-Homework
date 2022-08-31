


using System;

namespace T04WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;
        protected Animal(string name, double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }
        public virtual double IncreaseWeightCoefficient => default;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                name = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                weight = value;
            }
        }

        public int FoodEaten
        {
            get { return foodEaten; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                foodEaten = value;
            }
        }
        public virtual string ProduceSound()
        {
            return "";
        }
        public void EatFood()
        {
            Weight += FoodEaten * IncreaseWeightCoefficient;
            
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name},";
        }
    }
}
