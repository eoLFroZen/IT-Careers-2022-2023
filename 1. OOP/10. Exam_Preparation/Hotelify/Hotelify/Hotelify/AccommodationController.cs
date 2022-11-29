namespace Hotelify
{
    public class AccommodationController
    {
        // Can be replaced with Dictionary for both collections.
        private List<Accommodation> accommodations;
        private List<Guest> guests;

        public AccommodationController()
        {
            accommodations = new List<Accommodation>();
            guests = new List<Guest>();
        }

        public string CreateAccommodation(List<string> args)
        {
            int refNumber = int.Parse(args[0]);

            bool isAccommodationRegistered = accommodations
                .Where(accommodation => accommodation.RefNumber == refNumber)
                .Count() != 0;

            if (isAccommodationRegistered)
            {
                return $"Accommodation with number: {refNumber} already exists!";
            }

            string accommodationType = args[1];

            if (accommodationType != "Hotel" && accommodationType != "GuestHouse")
            {
                return $"Invalid type: {accommodationType}!";
            }

            string name = args[2];
            string description = args[3];
            int price = int.Parse(args[4]);
            string location = args[5];

            Accommodation accommodation = null;

            switch (accommodationType)
            {
                case "Hotel":
                    int stars = int.Parse(args[6]);
                    accommodation = new Hotel(refNumber, name, description, price, location, stars);
                    break;
                case "GuestHouse":
                    string hostName = args[6];
                    accommodation = new GuestHouse(refNumber, name, description, price, location, hostName);
                    break;
            }

            accommodations.Add(accommodation);

            return $"{refNumber}: {name} opened!";
        }
        public string CreateGuest(List<string> args)
        {
            string name = args[0];
            bool isGuestRegistered = guests.Where(guest => guest.Name == name).Count() != 0;

            if (isGuestRegistered)
            {
                return $"Can’t add guest {name}.";
            }

            int budget = int.Parse(args[1]);
            Guest guest = new Guest(name, budget);
            guests.Add(guest);

            return $"Successfully added guest {name} with {budget} lv. budget!";

        }
        public string AccommodationInfo(List<string> args)
        {
            int refNumber = int.Parse(args[0]);
            Accommodation accommodation = accommodations
                .FirstOrDefault(accommodation => accommodation.RefNumber == refNumber);

            if (accommodation != null)
            {
                return accommodation.ToString();
            }

            // NOTE: Null or Empty string not sure!
            return null;
        }
        public string GuestInfo(List<string> args)
        {
            string name = args[0];
            Guest guest = guests
                .FirstOrDefault(guest => guest.Name == name);

            if (guest != null)
            {
                return guest.ToString();
            }

            // NOTE: Null or Empty string not sure!
            return null;
        }
        public string ListPossibleAccommodationByPrice(List<string> args)
        {
            int budget = int.Parse(args[0]);

            List<Accommodation> budgetAccommodations = accommodations
                .Where(accommodation => accommodation.Price <= budget)
                .OrderByDescending(accommodation => accommodation.Price)
                .ToList();

            if (budgetAccommodations.Count == 0)
            {
                return "No suitable accommodations found.";
            }

            return string.Join(Environment.NewLine, budgetAccommodations);
        }
    }
}
