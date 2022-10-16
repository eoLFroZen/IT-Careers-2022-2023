using System;

namespace ShoppingSystem
{
    public abstract class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }

                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be 0 or positive!");
                }

                price = value;
            }
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            string nameString = $"Name: {Name}";
            string priceString = $"Price: {Price}";

            return nameString + Environment.NewLine + priceString;
        }
    }
}
