using FruitsAndVegetables.Constants;
using FruitsAndVegetables.Service.Interfaces;

namespace FruitsAndVegetables.Service
{
    public class ExchangeService : IExchangeService
    {
        public double ConvertLvToEur(double lv)
            => lv / ExchangeConstants.LvToEurRate;
    }
}
