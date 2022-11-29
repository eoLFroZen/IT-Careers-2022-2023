using System;

namespace ShoppingSystem
{
    public class ServiceProduct : Product
    {
        private double time;

        public double Time
        {
            get { return time; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Time should be greater than 0!");
                }

                time = value;
            }
        }

        public ServiceProduct(string name, double price, double time) 
            : base(name, price)
        {
            Time = time;
        }

        public override string ToString()
        {
            string timeString = $"Time: {Time:F2}";

            return base.ToString() + Environment.NewLine + timeString;
        }
    }
}
