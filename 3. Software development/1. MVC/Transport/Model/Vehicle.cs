namespace Transport.Model
{
    public abstract class Vehicle
    {
        protected double initialPrice;
        protected double dayPrice;
        protected double nightPrice;

        public int MinKm { get; set; }

        public Vehicle(double initialPrice, double dayPrice, double nightPrice, int minKm)
        {
            this.initialPrice = initialPrice;
            this.dayPrice = dayPrice;
            this.nightPrice = nightPrice;
            MinKm = minKm;
        }

        public double CalculateDayPrice(int km)
            => initialPrice + km * dayPrice;

        public double CalculateNightPrice(int km)
            => initialPrice + km * nightPrice;
    }
}
