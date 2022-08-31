

namespace T04WildFarm.Models
{
    public class Cat : Feline, IAnimal
    {
        
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }
        public override double IncreaseWeightCoefficient => 0.30;

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
