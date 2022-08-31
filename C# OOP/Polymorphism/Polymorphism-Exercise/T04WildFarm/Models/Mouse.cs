

namespace T04WildFarm.Models
{
   public class Mouse: Mammal, IAnimal
    {
        
        public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }
        public override double IncreaseWeightCoefficient => 0.10;
        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
