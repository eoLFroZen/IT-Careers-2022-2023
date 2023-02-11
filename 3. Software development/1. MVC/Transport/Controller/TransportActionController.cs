using Transport.Controller.Interfaces;
using Transport.Services;
using Transport.Services.Interfaces;
using Transport.View;
using Transport.View.Interfaces;

namespace Transport.Controller
{
    public class TransportActionController : ITransportActionController
    {
        private readonly IDisplay display;
        private readonly ITransportPriceService transportPriceService;

        public TransportActionController()
        {
            display = new Display();
            transportPriceService = new TransportPriceService();
        }

        public void Run()
        {
            int km;
            string dayOrNight;

            (km, dayOrNight) = display.ReadInput();

            double bestPrice = transportPriceService.GetBestTransportPrice(km, dayOrNight);

            display.PrintBestPrice(bestPrice);
        }
    }
}
