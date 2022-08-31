using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = new Car(50, 10);

            Console.WriteLine(car.FuelConsumption);



        }
    }
}
