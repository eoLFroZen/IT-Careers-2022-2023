using FruitsAndVegetables.Model;

namespace FruitsAndVegetables.Service.Interfaces
{
    public interface IHarvestService
    {
        double CalculateHarvestProfitInLv(IEnumerable<Produce> produces);
    }
}
