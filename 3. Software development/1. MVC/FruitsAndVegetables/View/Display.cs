using FruitsAndVegetables.Model;
using FruitsAndVegetables.View.Interfaces;

namespace FruitsAndVegetables.View
{
    public class Display : IDisplay
    {
        public IEnumerable<Produce> ReadProduces()
        {
            var vegetablesPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());

            var vegetablesQuantity = int.Parse(Console.ReadLine());
            var fruitsQuantity = int.Parse(Console.ReadLine());

            var vegetables = new Produce(vegetablesPrice, vegetablesQuantity);
            var fruits = new Produce(fruitsPrice, fruitsQuantity);

            return new[] { vegetables, fruits };
        }

        public void PrintHarvestProfit(double harvestProfit)
        {
            Console.WriteLine(harvestProfit);
        }
    }
}
