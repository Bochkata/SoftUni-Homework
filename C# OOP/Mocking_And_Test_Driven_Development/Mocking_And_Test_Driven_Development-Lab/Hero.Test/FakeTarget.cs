
namespace T01FakeAxeAndDummy
{
   public class FakeTarget : ITarget
   {
       public int Health => 10;
        public int Experience => 20;
        public void TakeAttack(int attackPoints)
        {
            
        }

        public int GiveExperience() => 20;
       

        public bool IsDead() => true;

   }
}
