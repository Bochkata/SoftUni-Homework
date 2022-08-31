
namespace T04WildFarm.Models
{
    public class Owl: Bird, IAnimal
    {
        
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }
        public override double IncreaseWeightCoefficient => 0.25;
        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        
    }
}
