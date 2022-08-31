using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            List<Product> allProducts = new List<Product>();

            string[] persons_Money = Console.ReadLine().Split(new[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);
            string[] products_Costs = Console.ReadLine().Split(new[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < persons_Money.Length - 1; i += 2)
                {
                    string currName = persons_Money[i];
                    decimal currMoney = decimal.Parse(persons_Money[i + 1]);
                    Person currPerson = new Person(currName, currMoney);
                    allPersons.Add(currPerson);
                }

                for (int i = 0; i < products_Costs.Length - 1; i += 2)
                {
                    string currProduct = products_Costs[i];
                    decimal currCost = decimal.Parse(products_Costs[i + 1]);
                    Product newProduct = new Product(currProduct, currCost);
                    allProducts.Add(newProduct);

                }


                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] personAndProduct = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string person = personAndProduct[0];
                    string product = personAndProduct[1];

                    Person buyer = allPersons.FirstOrDefault(x => x.Name == person);
                    Product _product = allProducts.FirstOrDefault(x => x.Name == product);
                    buyer.CanBuyProduct(_product);


                }
                foreach (Person person in allPersons)
                {
                    Console.WriteLine(person.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
