

using System;


namespace T02VehiclesExtension
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            FuelQuantity  = fuelQuantity > tankCapacity ? 0.00 : fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TankCapacity = tankCapacity;
        }

        protected abstract double AirConditionersConsumption { get; set; }
        public double TankCapacity { get; set; }
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
            if (amountOfFuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (amountOfFuel + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amountOfFuel} fuel in the tank");
            }
            return FuelQuantity += amountOfFuel;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
