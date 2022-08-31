using System;

namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;
        private const int MIN_HP = 30;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Pesho", 15, 50);
        }

        [Test]
        public void Ctor_CreatingWarrior()
        {
            Assert.IsNotNull(warrior);
        }
        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("")]
        public void Exception_NameShouldNotbeNullOrWhiteSpace(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 10, 50), "Name should not be empty or whitespace!");
        }
        [Test]

        public void NameShouldNotbeNullOrWhiteSpace()
        {
            Assert.AreEqual("Pesho", warrior.Name);

        }
        [Test]
        [TestCase(-1)]
        [TestCase(0)]

        public void Exception_DamageShouldNotBeLessThanZeroAndZero(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Gecata", damage, 50), "Damage value should be positive!");
        }
        [Test]

        public void DamageShouldBePositive()
        {
            Assert.AreEqual(15, warrior.Damage);

        }
        [Test]
        [TestCase(-1)]
        [TestCase(-1000)]

        public void Exception_HPShouldNotBeLessThanZero(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Gecata", 10, hp), "HP should not be negative!");
        }
        [Test]

        public void HPShouldBePositive()
        {
            Assert.AreEqual(50, warrior.HP);

        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Exception_MinHPShouldBe30ToBeABleToAttack(int hp)
        {
            warrior = new Warrior("Gosho", 13, hp);
            Warrior otherWarrior = new Warrior("Dimitrichko", 10, 35);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(otherWarrior), "Your HP is too low in order to attack other warriors!");
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Exception_OtherWarriorMinHPShouldBe30InOrderToBeAttacked(int hp)
        {

            Warrior otherWarrior = new Warrior("Dimitrichko", 10, hp);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(otherWarrior), $"Enemy HP must be greater than {MIN_HP} in order to attack him!");
        }
        [Test]
        public void Exception_WarriorCannotAttackIfHisHPIsLowerThanHPOfOtherWarrior()
        {
            Warrior otherWarrior = new Warrior("Dimitrichko", 60, 100);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(otherWarrior), $"You are trying to attack too strong enemy");
        }
        [Test]
        public void HPDecreasesWithOtherWarriorDamage()
        {
            Warrior otherWarrior = new Warrior("Dimitrichko", 15, 100);
            Assert.AreEqual(35, warrior.HP - otherWarrior.Damage);
            Assert.AreEqual(85, otherWarrior.HP-warrior.Damage);
        }
        [Test]
        public void WarriorDamageExceedsOtherWarriorHP()
        {
            warrior = new Warrior("Gosho", 120, 120);
            Warrior otherWarrior = new Warrior("Dimitrichko", 15, 100);
            warrior.Attack(otherWarrior);
            Assert.AreEqual(0, otherWarrior.HP);
            Assert.AreEqual(105, warrior.HP);
        }
        [Test]
        public void OtherWarriorHPDecresesWithWarriorDamage()
        {

            Warrior otherWarrior = new Warrior("Dimitrichko", 15, 100);
            warrior.Attack(otherWarrior);
            Assert.AreEqual(85, otherWarrior.HP);
            Assert.AreEqual(35, warrior.HP);
        }
    }
}
