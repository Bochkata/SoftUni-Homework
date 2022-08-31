


namespace T01Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumptionPerKm) : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        protected override double AirConditionersConsumption => airConditionerConsumption;
        public override double Refuel(double amountOfFuel)
        {
            return base.Refuel(amountOfFuel * 0.95);
        }
    }
}
