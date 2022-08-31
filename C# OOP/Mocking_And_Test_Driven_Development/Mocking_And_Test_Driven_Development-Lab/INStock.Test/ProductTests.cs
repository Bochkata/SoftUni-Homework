using System;

namespace INStock.Tests
{
    using NUnit.Framework;
    [TestFixture]
    public class ProductTests
    {
        private Product product;
        [SetUp]
        public void SetUp()
        {
            product = new Product("aaaaaaa", 20.5m, 5);
        }

        [Test]
        [TestCase("", 20.5, 5)]
        [TestCase(" ", 20.5, 5)]
        [TestCase(null, 20.5, 5)]
        [TestCase("aaa", 0, 5)]
        [TestCase("bbb", -5, 5)]
        [TestCase("bbb", -5, 5)]
        [TestCase("bbb", 5, -5)]
        public void ExceptionsWhenCreatingObjectThroughCtor(string label, decimal price, int quantity)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => product = new Product(label, price, quantity));
        }

        [Test]

        public void CtorCreatingValidProducts()
        {
            string label = "aaaaaaa";
            decimal price = 20.5m;
            int quantity = 5;
           Assert.AreEqual(label, product.Label);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(quantity, product.Quantity);

        }

        [Test]

        public void ReturnZeroWhenComparingTwoProductsByEqualPrice()
        {
            Product product2 = new Product("aaaa", 20.5m, 7);
            product.CompareTo(product2);
            int result = product.Price.CompareTo(product2.Price);
            Assert.AreEqual(0,result);
        }
        [Test]
        public void ReturnOneWhenComparingTwoProductsWithUnequalPrice()
        {
            Product product2 = new Product("aaaa", 20.2m, 7);
            product.CompareTo(product2);
            Assert.AreEqual(1, product.Price.CompareTo(product2.Price));
        }
        [Test]
        public void ReturnMinusWhenComparingTwoProductsWithUnequalPrice()
        {
            Product product2 = new Product("aaaa", 20.7m, 7);
            product.CompareTo(product2);
            Assert.AreEqual(-1, product.Price.CompareTo(product2.Price));
        }
        [Test]
        public void ReturnZeroWhenComparingTwoProductsByEqualPriceAndEqualQuantity()
        {
            Product product2 = new Product("aa", 20.5m, 5);
            product.CompareTo(product2);
            Assert.AreEqual(0, product.Quantity.CompareTo(product2.Quantity));
        }
        [Test]
        public void ReturnOneWhenComparingTwoProductsByEqualPriceAndUnequalQuantity()
        {
            Product product2 = new Product("aa", 20.5m, 2);
            product.CompareTo(product2);
            Assert.AreEqual(1, product.Quantity.CompareTo(product2.Quantity));
        }
        [Test]
        public void ReturnMinusWhenComparingTwoProductsByEqualPriceAndUnequalQuantity()
        {
            Product product2 = new Product("aa", 20.5m, 7);
            product.CompareTo(product2);
            Assert.AreEqual(-1, product.Quantity.CompareTo(product2.Quantity));
        }





    }
}