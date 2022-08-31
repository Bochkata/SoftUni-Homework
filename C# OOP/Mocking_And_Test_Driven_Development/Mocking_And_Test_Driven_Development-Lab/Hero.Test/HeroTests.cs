using Moq;
using NUnit.Framework;
using T01FakeAxeAndDummy;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void GainXPWhenTargetIsDead()
        {
            string name = "Pesho";
            //IWeapon fakeAxe = new FakeWeapon();
            //ITarget fakeTarget = new FakeTarget();
            //Hero hero = new Hero(name, fakeAxe);
            //hero.Attack(fakeTarget);
            //Assert.AreEqual(20, hero.Experience);

            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero(name, fakeWeapon.Object);

            hero.Attack(fakeTarget.Object);

            Assert.That(hero.Experience,Is.EqualTo(20));

        }
           
    }
}