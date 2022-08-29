using System;
using System.Collections.Generic;

namespace T05ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> allPersons = new List<Person>();
            List<Product> allProducts = new List<Product>();

            for (int i = 0; i < line1.Length; i += 2)
            {
                Person currentPerson = new Person();
                {
                    string currentName = line1[i];
                    currentPerson.Name = currentName;
                    double currentMoney = double.Parse(line1[i + 1]);
                    currentPerson.Money = currentMoney;

                }
                allPersons.Add(currentPerson);

            }

            string[] line2 = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < line2.Length; i += 2)
            {
                Product currProduct = new Product();
                {
                    string currentProduct = line2[i];
                    currProduct.ProductName = currentProduct;
                    double currentProductCost = double.Parse(line2[i + 1]);
                    currProduct.ProductCost = currentProductCost;
                }
                allProducts.Add(currProduct);
            }

            string command = String.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] subcommands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = subcommands[0];
                string curProduct = subcommands[1];

                Person person = allPersons.Find(x => x.Name == currentName);
                Product product = allProducts.Find(x => x.ProductName == curProduct);

                if (person.CanBuy(person.Money, product.ProductCost))
                {
                    person.boughtProducts.Add(product.ProductName);
                    person.Money -= product.ProductCost;
                    Console.WriteLine($"{person.Name} bought {product.ProductName}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.ProductName}");
                }
            }

            foreach (Person person in allPersons)
            {
                if (person.boughtProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.boughtProducts)}");
                }

            }

        }
        class Person
        {
            public string Name { get; set; }
            public double Money { get; set; }
            public List<string> boughtProducts = new List<string>();

            public bool CanBuy(double moneyAvailable, double productCost)
            {
                double result = moneyAvailable - productCost;
                if (result >= 0)
                {
                    return true;
                }
                return false;
            }

        }
        class Product
        {
            public string ProductName { get; set; }
            public double ProductCost { get; set; }
        }
    }
}
