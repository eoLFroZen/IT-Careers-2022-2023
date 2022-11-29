namespace Vehicles
{
    public abstract class Vehicle : IFuel, IDrivable
    {
        public double FuelQuantity { get; protected set; }

        public double LitersPerKm { get; protected set; }

        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
        }

        public virtual void Refuel(double quantity)
        {
            FuelQuantity += quantity;
        }

        public abstract string Drive(double distance);
    }
}
