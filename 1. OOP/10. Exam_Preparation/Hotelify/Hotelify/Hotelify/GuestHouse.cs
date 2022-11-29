namespace Hotelify
{
    public class GuestHouse : Accommodation
    {
        private string hostName;

        public GuestHouse(int refNumber, string name, string description, int price, string location, string hostName) 
            : base(refNumber, name, description, price, location)
        {
            this.hostName = hostName;
        }
    }
}
