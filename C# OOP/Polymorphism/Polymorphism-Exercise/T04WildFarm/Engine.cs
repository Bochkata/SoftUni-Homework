

using System;
using System.Collections.Generic;
using T04WildFarm.Models;

namespace T04WildFarm
{
    public class Engine
    {
        string Input { get; set; }

        public void Run()
        {

            List<Animal> allAnimals = new List<Animal>();
            Animal animal = null;
            Food food = null;
            while ((Input = Console.ReadLine()) != "End")
            {
                string[] animalInput = Input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] foodInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string animalType = animalInput[0];
                string currName = animalInput[1];
                double currWeight = double.Parse(animalInput[2]);

                string currFoodType = foodInput[0];
                int currFoodQnty = int.Parse(foodInput[1]);

                switch (animalType)
                {

                    case nameof(Owl):
                        double currWingsSize = double.Parse(animalInput[3]);
                        animal = new Owl(currName, currWeight, currFoodQnty, currWingsSize);
                        break;
                    case nameof(Hen):
                        double curWingsSize = double.Parse(animalInput[3]);
                        animal = new Hen(currName, currWeight, currFoodQnty, curWingsSize);
                        break;
                    case nameof(Mouse):
                        string currLivingRegion = animalInput[3];
                        animal = new Mouse(currName, currWeight, currFoodQnty, currLivingRegion);
                        break;
                    case nameof(Dog):
                        string curLivingRegion = animalInput[3];
                        animal = new Dog(currName, currWeight, currFoodQnty, curLivingRegion);
                        break;
                    case nameof(Cat):
                        string currentLivingRegion = animalInput[3];
                        string currBreed = animalInput[4];
                        animal = new Cat(currName, currWeight, currFoodQnty, currentLivingRegion, currBreed);
                        break;
                    case nameof(Tiger):
                        string currentLivRegion = animalInput[3];
                        string curBreed = animalInput[4];
                        animal = new Tiger(currName, currWeight, currFoodQnty, currentLivRegion, curBreed);
                        break;
                    default: throw new ArgumentException();

                }
                switch (currFoodType)
                {
                    case nameof(Vegetable): food = new Vegetable(currFoodQnty); break;
                    case nameof(Fruit): food = new Fruit(currFoodQnty); break;
                    case nameof(Seeds): food = new Seeds(currFoodQnty); break;
                    case nameof(Meat): food = new Meat(currFoodQnty); break;
                    default: throw new ArgumentException();
                }
                Console.WriteLine(animal.ProduceSound());
                ValidateFood(animal, food);
                allAnimals.Add(animal);
            }


            foreach (Animal an in allAnimals)
            {

                Console.WriteLine(an.ToString());
            }

        }

        private void ValidateFood(Animal animal, Food food)
        {
            try
            {
                if (animal.GetType().Name == "Mouse" && (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit"))
                {
                    animal.EatFood();
                }
                else if (animal.GetType().Name == "Cat" && (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat"))
                {
                    animal.EatFood();
                }
                else if (animal.GetType().Name == "Tiger" && food.GetType().Name == "Meat")
                {
                    animal.EatFood();
                }
                else if (animal.GetType().Name == "Dog" && food.GetType().Name == "Meat")
                {
                    animal.EatFood();
                }
                else if (animal.GetType().Name == "Owl" && food.GetType().Name == "Meat")
                {
                    animal.EatFood();
                }
                else if (animal.GetType().Name == "Hen" && (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit" || food.GetType().Name == "Meat" || food.GetType().Name == "Seeds"))
                {
                    animal.EatFood();
                }
                else
                {
                    animal.FoodEaten = 0;
                    throw new ArgumentException($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }

}
