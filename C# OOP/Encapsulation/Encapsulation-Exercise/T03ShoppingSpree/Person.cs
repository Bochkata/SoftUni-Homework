using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
       
        private string name;
        private decimal money;
        private List<Product> bagOfProducts = new List<Product>();

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public IReadOnlyCollection<Product> allProducts => bagOfProducts.AsReadOnly();
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        

        public void CanBuyProduct(Product product)
        {
            if (product.Cost > money)
            {
                Console.WriteLine($"{Name} can't afford {product}");
            }
            else
            {
                money -= product.Cost;
                bagOfProducts.Add(product);
                Console.WriteLine($"{Name} bought {product}");
               
            }
            
        }

        public override string ToString()
        {
            string result = allProducts.Count == 0 ? $"{Name} - Nothing bought": $"{Name} - {string.Join(", ", allProducts)}";
           return result;
        }
    }
}
