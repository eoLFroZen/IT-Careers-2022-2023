using Transport.Model;
using Transport.Services.Interfaces;

namespace Transport.Services
{
    public class TransportPriceService : ITransportPriceService
    {
        private Vehicle taxi;
        private Vehicle bus;
        private Vehicle train;

        public TransportPriceService()
        {
            taxi = new Taxi();
            bus = new Bus();
            train = new Train();
        }

        public double GetBestTransportPrice(int km, string dayOrNight)
        {
            double taxiPrice = double.MaxValue;
            if (km >= taxi.MinKm)
            {
                taxiPrice = GetTransportPrice(km, dayOrNight, taxi);
            }

            double busPrice = double.MaxValue;
            if (km >= bus.MinKm)
            {
                busPrice = GetTransportPrice(km, dayOrNight, bus);
            }

            double trainPrice = double.MaxValue;
            if (km >= train.MinKm)
            {
                trainPrice = GetTransportPrice(km, dayOrNight, train);
            }

            return Math.Min(taxiPrice, Math.Min(busPrice, trainPrice));
        }

        private double GetTransportPrice(int km, string dayOrNight, Vehicle vehicle)
        {
            if (dayOrNight == Constants.Day)
            {
                return vehicle.CalculateDayPrice(km);
            }

            return vehicle.CalculateNightPrice(km);
        }
    }
}
