using System;

namespace ShoppingSystem
{
    public class PhysicalProduct : Product
    {
        private double weight;

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight cannot be less or equal to 0!");
                }

                weight = value;
            }
        }

        public PhysicalProduct(string name, double price, double weight) 
            : base(name, price)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            string weightString = $"Weight: {Weight:F2}";

            return base.ToString() + Environment.NewLine + weightString;
        }
    }
}
