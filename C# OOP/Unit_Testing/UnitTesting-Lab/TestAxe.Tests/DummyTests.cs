using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
       
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void Initialization()
        {
            axe = new Axe(20, 10);
            dummy = new Dummy(100, 20);
        }
        [Test]
        public void DummyLoosesHealthIfAttacked()
        {
            axe.Attack(dummy);
            Assert.That(dummy.Health, Is.EqualTo(80), "Dummy does not lose health");
        }
        [Test]
        public void DummyThrowsExceptionIfAttacked()
        {
            for (int i = 0; i < 5; i++)
            {
                axe.Attack(dummy);
            }
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }
        [Test]
        public void DeadDummyCanGiveXP()
        {
            for (int i = 0; i < 5; i++)
            {
                axe.Attack(dummy);
            }
            Assert.That(dummy.GiveExperience(), Is.EqualTo(20));
        }
        [Test]
        public void AliveDummyCannotGiveXP()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);
            Assert.That(()=>dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
         
        }
    }
}