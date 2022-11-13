namespace _12._1_Shop
{
    public class Product
    {
        public string Name { get; private set; }

        public string Barcode { get; private set; }

        public double Price { get; private set; }

        public double Quantity { get; private set; }

        public Product(string name, string barcode, double price, double quantity)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
            Quantity = quantity;
        }

        public void Sell(double quantity)
        {
            Quantity -= quantity;
        }

        public void UpdateQuantity(double quantity)
        {
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} ({Barcode})";
        }
    }
}
