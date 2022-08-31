

namespace T01FakeAxeAndDummy
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 1000;
        public int DurabilityPoints => 1;
        public void Attack(ITarget target)
        {
           target.TakeAttack(AttackPoints);
        }
    }
}
