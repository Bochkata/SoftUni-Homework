
namespace T01FakeAxeAndDummy
{
    public interface ITarget
    {
        int Health { get; }
       int Experience { get; }


       public void TakeAttack(int attackPoints);


       public int GiveExperience();


       public bool IsDead();

    }
}
