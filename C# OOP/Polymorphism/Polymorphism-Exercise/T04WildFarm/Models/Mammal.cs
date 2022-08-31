
using System;

namespace T04WildFarm.Models
{
   public abstract class Mammal : Animal, IAnimal
   {
       private string livingRegion;
        protected Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get
            {
                return livingRegion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                livingRegion = value;
            }
        }

   }
}
