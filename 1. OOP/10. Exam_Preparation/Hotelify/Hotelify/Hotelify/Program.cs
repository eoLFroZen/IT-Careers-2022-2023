using Hotelify;

string input;
AccommodationController controller = new AccommodationController();

while ((input = Console.ReadLine()) != "End")
{
    List<string> splittedInput = input
        .Split("|")
        .ToList();
    string command = splittedInput[0];
    string result = "";

    splittedInput = splittedInput
        .Skip(1)
        .ToList();

    switch (command)
    {
        case "CreateAccommodation":
            result = controller.CreateAccommodation(splittedInput);
            break;
        case "CreateGuest":
            result = controller.CreateGuest(splittedInput);
            break;
        case "AccommodationInfo":
            result = controller.AccommodationInfo(splittedInput);
            break;
        case "GuestInfo":
            result = controller.GuestInfo(splittedInput);
            break;
        case "ListPossibleAccommodationByPrice":
            result = controller.ListPossibleAccommodationByPrice(splittedInput);
            break;
    }

    Console.WriteLine(result);
}