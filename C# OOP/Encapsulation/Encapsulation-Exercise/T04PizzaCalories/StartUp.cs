using System;



namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();

            string[] doughInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] toppingsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                string pizzaName = command[1];
                string flourType = doughInput[1];
                string bakingTech = doughInput[2];
                double doughWeight = double.Parse(doughInput[3]);

                Dough dough = new Dough(flourType, bakingTech, doughWeight);

                Pizza pizza = new Pizza(pizzaName, dough);

                while (toppingsInput[0].ToLower() != "end")
                {
                    string toppingType = toppingsInput[1];
                    double toppingWeight = double.Parse(toppingsInput[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);
                    toppingsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }


                Console.WriteLine($"{pizza.Name} - {pizza.PizzaCalories:f2} Calories.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}