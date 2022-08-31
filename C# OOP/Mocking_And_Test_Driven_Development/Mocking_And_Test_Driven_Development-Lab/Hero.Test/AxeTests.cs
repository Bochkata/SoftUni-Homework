using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void InitializationTest()
        {
            axe = new Axe(10, 10);
            dummy = new Dummy(100, 5);
        }
        [Test]
        public void TestIfAxeLooses1DurabiltyAfterAttack()
        {
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe durability didn't change");
           //Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe didn't lose 1 point");
        }
        [Test]
        public void AttackWithBrokenAxe()
        {
            for (int i = 0; i < 10; i++)
            {
                axe.Attack(dummy);
                
            }
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}