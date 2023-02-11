using FruitsAndVegetables.Model;

namespace FruitsAndVegetables.View.Interfaces
{
    public interface IDisplay
    {
        IEnumerable<Produce> ReadProduces();

        void PrintHarvestProfit(double harvestProfit);
    }
}
