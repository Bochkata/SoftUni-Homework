

namespace T04WildFarm.Models
{
    public class Hen : Bird, IAnimal
    {
        
        public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }
        public override double IncreaseWeightCoefficient => 0.35;
       
        public override string ProduceSound()
        {
            return "Cluck";
        }
       
    }

}
