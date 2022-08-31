using System;


namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Warrior attacker;
        private Warrior defender;

        [SetUp]
        public void SetUp()
        {
          attacker = new Warrior("Pesho", 15, 50);
            defender = new Warrior("Gecata", 20, 100);
            arena = new Arena();
          
        }
        [Test]
        public void Ctor_InitializeList()
        {
            attacker = new Warrior("Pesho", 15, 50);
            defender = new Warrior("Gecata", 20, 100);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            Assert.AreEqual(2, arena.Warriors.Count);

        }
        [Test]
        public void Ctor_Test()
        {
            arena = new Arena();
            Assert.IsNotNull(arena.Warriors);

        }
        [Test]
        public void AddingWarriors()
        {

           arena.Enroll(attacker);
            arena.Enroll(defender);
            Assert.AreEqual(2, arena.Count);
           
        }
        [Test]
        public void Exception_ShouldNotEnrollAlreadyEnrolledWarrior()
        {
            Warrior anotherWarrior = new Warrior("Pesho", 15, 25);
           arena.Enroll(attacker);
           arena.Enroll(defender);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(anotherWarrior),
                "Warrior is already enrolled for the fights!");
        }
        [Test]
        public void EnrollingNewWarrior()
        {
            Warrior anotherWarrior = new Warrior("Dimitrichko", 10, 60);
           arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Enroll(anotherWarrior);
            Assert.AreEqual(3, arena.Count);
          
        }
       
        [Test]
        public void Exception_FightWithNonExistingAttacker()
        {
            Warrior anotherAttacker = new Warrior("Dimitrichko", 10, 60);
            Warrior anotherDefender = new Warrior("Gosho", 5, 70);

            arena.Enroll(anotherDefender);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(anotherAttacker.Name, anotherDefender.Name),
                $"There is no fighter with name {anotherAttacker.Name} enrolled for the fights!");

        }
        [Test]
        public void Exception_FightWithNonExistingDefender()
        {
            Warrior anotherAttacker = new Warrior("Dimitrichko", 10, 60);
            Warrior anotherDefender = new Warrior("Gosho", 5, 70);

            arena.Enroll(anotherAttacker);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(anotherAttacker.Name, anotherDefender.Name),
                $"There is no fighter with name {anotherDefender.Name} enrolled for the fights!");

        }
        [Test]
        public void FightExistingWarriors()
        {
            Warrior anotherAttacker = new Warrior("Dimitrichko", 10, 60);
            Warrior anotherDefender = new Warrior("Gosho", 5, 70);

            arena.Enroll(anotherAttacker);
            arena.Enroll(anotherDefender);
          arena.Fight(anotherAttacker.Name, anotherDefender.Name);
            Assert.AreEqual(60, anotherDefender.HP);
            Assert.AreEqual(55, anotherAttacker.HP);

        }
    }
}
