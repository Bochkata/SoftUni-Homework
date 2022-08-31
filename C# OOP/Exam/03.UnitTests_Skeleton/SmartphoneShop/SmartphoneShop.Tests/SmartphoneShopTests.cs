using System;
using NUnit.Framework;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        private Smartphone smartphone;
        private Shop shop;

        [SetUp]
        public void SetUp()
        {
            smartphone = new Smartphone("aaa", 50);
            shop = new Shop(8);
            }

        [Test]
        public void CheckCtor()
        {
            Assert.IsNotNull(smartphone);
            Assert.IsNotNull(shop);
        }

        [Test]
        public void Exception_CheckCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Shop(-1), "Invalid capacity.");
        }

        [Test]
        public void Exception_CheckAddMethodModelName()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("aaa", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            Assert.Throws<InvalidOperationException>((() => shop.Add(smartphone3)),
                $"The phone model {smartphone3.ModelName} already exist.");

        }
        [Test]
        public void Exception_CheckAddMethodCapacity()
        {
            shop = new Shop(2);
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            Assert.Throws<InvalidOperationException>((() => shop.Add(smartphone3)),
                "The shop is full.");

        }
        [Test]
        public void CheckAddMethodCapacity()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
           shop.Add(smartphone3);
            Assert.AreEqual(3, shop.Count);
        }
        [Test]
        public void Exception_CheckRemoveMethod()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
          Assert.Throws<InvalidOperationException>(() => shop.Remove("ddd"), $"The phone model ddd doesn't exist.");
        }
        [Test]
        public void CheckRemoveMethodCapacity()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
            shop.Remove(smartphone.ModelName);
            Assert.AreEqual(2, shop.Count);
        }
        [Test]
        public void Exception_CheckMethodTestPhoneModel()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
           Assert.Throws<InvalidOperationException>(() => shop.TestPhone("ddd", 80), "The phone model ddd doesn't exist.");
        }
        [Test]
        public void Exception_CheckMethodTestPhoneBatteryUsage()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("aaa", 80), $"The phone model {smartphone.ModelName} is low on batery.");
        }
        [Test]
        public void CheckMethodTestPhone()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
          shop.TestPhone("aaa", 30);
          Assert.AreEqual(20, smartphone.CurrentBateryCharge);
        }
        [Test]
        public void Exception_CheckMethodChargePhone()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
            Assert.Throws<InvalidOperationException>(() => shop.ChargePhone("ddd"), "The phone model ddd doesn't exist.");
        }

        [Test]
        public void CheckMethodChargePhone()
        {
            Smartphone smartphone2 = new Smartphone("bbb", 70);
            Smartphone smartphone3 = new Smartphone("ccc", 80);
            shop.Add(smartphone);
            shop.Add(smartphone2);
            shop.Add(smartphone3);
            shop.TestPhone("aaa", 30);
            shop.ChargePhone("aaa");
            Assert.AreEqual(50, smartphone.CurrentBateryCharge);
        }

    }
}