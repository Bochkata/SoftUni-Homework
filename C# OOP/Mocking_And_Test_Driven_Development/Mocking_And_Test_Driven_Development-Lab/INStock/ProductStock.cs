using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using INStock.Contracts;

namespace INStock
{
    public class ProductStock : IProductStock
    {
        public ProductStock()
        {
            Products = new List<IProduct>();
        }

        public List<IProduct> Products { get; set; }
        public IEnumerator<IProduct> GetEnumerator()
        {
            foreach (IProduct product in Products)
            {
                yield return product;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => Products.Count;

        public IProduct this[int index]
        {
            get => Products[index];
            set
            {

                if (index > 0 && index <= Products.Count)
                {
                    Products[index] = value;
                }
            }
            
        }

        public bool Contains(IProduct product)
        {
            return Products.Any(x => x.Label == product.Label);
        }
        

        public void Add(IProduct product)
        {
            if (Products.All(x => x.Label != product.Label))
            {
                Products.Add(product);
            }
        }

        public bool Remove(IProduct product)
        {
            return Products.Remove(product);
        }

        public IProduct Find(int index)
        {
            if (index < 0 || index >= Products.Count)
            {
                throw new IndexOutOfRangeException("The index is not valid");
            }

            return Products[index];
        }

        public IProduct FindByLabel(string label)
        {
            if (Products.All(x => x.Label != label))
            {
                throw new ArgumentException("No product with this label available in stock");
            }

            return Products.First(x => x.Label == label);
        }

        public IProduct FindMostExpensiveProduct()
        {
            return Products.OrderBy(x => x.Price).LastOrDefault();
        }

        public IEnumerable<IProduct> FindAllInRange(double lo, double hi)
        {
            List<IProduct> allProductsInPriceRange =
                Products.FindAll(x => x.Price >= (decimal)lo && x.Price <= (decimal)hi).OrderBy(x => x.Price).ToList();
            return allProductsInPriceRange;
        }

        public IEnumerable<IProduct> FindAllByPrice(double price)
        {
            List<IProduct> allProductsWIthThatPrice = Products.FindAll(x => x.Price == (decimal)price);
            return allProductsWIthThatPrice;
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            return Products.FindAll(x => x.Quantity == quantity);
        }
    }
}
