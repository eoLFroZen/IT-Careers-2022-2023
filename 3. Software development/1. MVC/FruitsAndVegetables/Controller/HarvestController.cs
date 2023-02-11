using FruitsAndVegetables.Controller.Interfaces;
using FruitsAndVegetables.Service.Interfaces;
using FruitsAndVegetables.View.Interfaces;

namespace FruitsAndVegetables.Controller
{
    public class HarvestController : IHarvestController
    {
        private readonly IDisplay display;
        private readonly IHarvestService harvestService;
        private readonly IExchangeService exchangeService;

        public HarvestController(
            IDisplay display, 
            IHarvestService harvestService, 
            IExchangeService exchangeService)
        {
            this.display = display;
            this.harvestService = harvestService;
            this.exchangeService = exchangeService;
        }

        public void CalculateHarvestProfit()
        {
            var produces = display.ReadProduces();
            var harvestPriceInLv = harvestService.CalculateHarvestProfitInLv(produces);
            var harvestPriceInEur = exchangeService.ConvertLvToEur(harvestPriceInLv);
            display.PrintHarvestProfit(harvestPriceInEur);
        }
    }
}
