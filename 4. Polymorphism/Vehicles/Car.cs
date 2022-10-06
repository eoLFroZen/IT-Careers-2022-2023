namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionerFuelPerKm = 0.9;

        public Car(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm)
        {
        }

        public override string Drive(double distance)
        {
            double neededFuel = (LitersPerKm + airConditionerFuelPerKm) * distance;

            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"Car travelled {distance} km";
            }

            return "Car needs refueling";
        }
    }
}
