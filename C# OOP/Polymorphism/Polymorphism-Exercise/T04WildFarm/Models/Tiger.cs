

namespace T04WildFarm.Models
{
   public class Tiger : Feline, IAnimal
    {
        
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
        public override double IncreaseWeightCoefficient => 1.00;
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

    }
}
