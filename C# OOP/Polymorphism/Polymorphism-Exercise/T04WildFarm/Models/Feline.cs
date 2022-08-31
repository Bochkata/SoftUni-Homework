

using System;

namespace T04WildFarm.Models
{
    public abstract class Feline : Mammal, IAnimal
    {
        private string breed;
        protected Feline(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion)
        {
            Breed = breed;
        }

        public string Breed
        {
            get
            {
                return breed;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                breed = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
