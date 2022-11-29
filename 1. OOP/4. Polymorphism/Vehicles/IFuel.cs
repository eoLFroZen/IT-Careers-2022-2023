namespace Vehicles
{
    public interface IFuel
    {
        double FuelQuantity { get; }

        double LitersPerKm { get; }

        void Refuel(double quantity);
    }
}
