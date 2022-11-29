namespace Hotelify
{
    public class Hotel : Accommodation
    {
        private int stars;

        public Hotel(int refNumber, string name, string description, int price, string location, int stars)
            : base(refNumber, name, description, price, location)
        {
            this.stars = stars;
        }
    }
}