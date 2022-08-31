

using System;


namespace T01Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        protected abstract double AirConditionersConsumption { get; }
       
        public double FuelQuantity { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public void Drive(double distance)
        {
            double leftFuel = FuelQuantity - (FuelConsumptionPerKm + AirConditionersConsumption) * distance;

            if (leftFuel < 0)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                FuelQuantity -= (FuelConsumptionPerKm + AirConditionersConsumption) * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
        }

        public virtual double Refuel(double amountOfFuel)
        {
            return FuelQuantity += amountOfFuel;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
