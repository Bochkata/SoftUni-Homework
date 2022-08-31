

namespace T04WildFarm.Models
{
    public class Dog : Mammal, IAnimal
    {
        
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }
        public override double IncreaseWeightCoefficient => 0.40;
        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Weight}, {LivingRegion}, {FoodEaten}]";
        }

    }
}
