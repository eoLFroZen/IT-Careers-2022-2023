using FruitsAndVegetables.Model;
using FruitsAndVegetables.Service.Interfaces;

namespace FruitsAndVegetables.Service
{
    public class HarvestService : IHarvestService
    {
        public double CalculateHarvestProfitInLv(IEnumerable<Produce> produces)
            => produces.Sum(produce => produce.PricePerKgInLv * produce.QuantityInKgs);
    }
}
