using System;
using System.Collections.Generic;
using System.Linq;
using INStock.Contracts;



namespace INStock.Tests
{
    using NUnit.Framework;
    [TestFixture]
    public class ProductStockTests
    {
        private ProductStock productStock;
        [SetUp]
        public void SetUp()
        {
            productStock = new ProductStock();
        }

        [Test]
        public void CtorTest()
        {
            Assert.IsNotNull(productStock.Products);
        }

        [Test]
        public void CheckWhetherCanAddNewProductWithDifferentLabelToList()
        {
            for (int i = 0; i < 9; i++)
            {
                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }
            Assert.AreEqual(9, productStock.Count);
        }
        [Test]
        public void CheckWhetherEnumeratorReturnsElementsOfTheList()
        {

            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }

            List<IProduct> expected = new List<IProduct>();
            foreach (IProduct product in productStock)
            {
                expected.Add(product);
            }

            CollectionAssert.AreEqual(expected, productStock.ToList());
        }

        [Test]
        public void CheckIfProductIsContainedInList()
        {
            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }

            Product product = new Product("aa0", 15, 5);

            Assert.IsTrue(productStock.Contains(product));
        }
        [Test]

        [TestCase(2)]
        public void CheckIfProductExistsAtCertainIndex(int index)
        {
            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }
            Assert.AreEqual(productStock.ElementAt(index), productStock[index]);
        }
        [Test]
        public void CheckIfProductCanBeRemovedFromList()
        {
            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }

            IProduct product = productStock.Products.FirstOrDefault(x => x.Label == "aa0");
            Assert.IsTrue(productStock.Remove(product));
        }
        [Test]
        [TestCase(-1)]
        public void Exception_WhenFindMethodUsedWIthInvalidIndex(int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => productStock.Find(index));
        }
        [Test]
        [TestCase(1)]
        public void ReturnProductWhenFindMethodUsedWIthValidIndex(int index)
        {
            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }

            IProduct product = productStock.ElementAt(index);
            Assert.AreEqual(product, productStock.Find(index));
        }
        [Test]
        public void Exception_CheckFindByLabelMethod()
        {
            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }
            Assert.Throws<ArgumentException>(() => productStock.FindByLabel("aaaab"), "No product with this label available in stock");
        }
        [Test]
        public void CheckFindByLabelMethodWhenWorkingCorrectly()
        {
            for (int i = 0; i < 9; i++)
            {

                productStock.Add(new Product($"aa{i}", 20m + i, 5 + i));
            }

            Assert.AreEqual(productStock.FirstOrDefault(x => x.Label == "aa0"), productStock.FindByLabel("aa0"));
        }
        [Test]
        public void CheckFindMostExpensiveProduct()
        {
            IProduct product1 = new Product("aaa", 20m, 5);
            IProduct product2 = new Product("aab", 30m, 5);
            IProduct product3 = new Product("aac", 50m, 5);
            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            Assert.AreEqual(product3, productStock.FindMostExpensiveProduct());
        }
        [Test]
       
        public void CheckFindAllProductsInCertainPriceRange()
        {
            IProduct product1 = new Product("aaa", 20m, 5);
            IProduct product2 = new Product("aab", 30m, 5);
            IProduct product3 = new Product("aac", 50m, 5);
            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            List<IProduct> products = new List<IProduct>() {product2, product3};
                
            CollectionAssert.AreEqual(products, productStock.FindAllInRange((double)30m, (double)50m));
        }
        [Test]

        public void CheckFindAllProductsByCertainPrice()
        {
            IProduct product1 = new Product("aaa", 20m, 5);
            IProduct product2 = new Product("aab", 20m, 5);
            IProduct product3 = new Product("aac", 50m, 5);
            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            List<IProduct> products = new List<IProduct>() { product1, product2 };

            CollectionAssert.AreEqual(products, productStock.FindAllByPrice((double)20m));
        }
        [Test]

        public void CheckFindAllProductsByQuantity()
        {
            IProduct product1 = new Product("aaa", 20m, 5);
            IProduct product2 = new Product("aab", 30m, 5);
            IProduct product3 = new Product("aac", 50m, 5);
            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            List<IProduct> products = new List<IProduct>() {product1, product2, product3};

            CollectionAssert.AreEqual(products, productStock.FindAllByQuantity(5));
        }


    }
}
