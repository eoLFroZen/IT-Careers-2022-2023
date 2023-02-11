namespace FruitsAndVegetables.Model
{
    public class Produce
    {
        public double PricePerKgInLv { get; set; }

        public int QuantityInKgs { get; set; }

        public Produce(double pricePerKgInLv, int quantityInKgs)
        {
            PricePerKgInLv = pricePerKgInLv;
            QuantityInKgs = quantityInKgs;
        }
    }
}
