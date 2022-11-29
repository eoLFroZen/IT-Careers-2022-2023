namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionerFuelPerKm = 1.6;
        private const double refuelRate = 0.95;

        public Truck(double fuelQuantity, double litersPerKm) 
            : base(fuelQuantity, litersPerKm)
        {
        }

        public override void Refuel(double quantity)
        {
            FuelQuantity += refuelRate * quantity;
        }

        public override string Drive(double distance)
        {
            double neededFuel = (LitersPerKm + airConditionerFuelPerKm) * distance;

            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"Truck travelled {distance} km";
            }

            return "Truck needs refueling";
        }
    }
}
