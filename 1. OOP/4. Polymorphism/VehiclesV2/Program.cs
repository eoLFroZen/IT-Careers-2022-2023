using VehiclesV2.Vehicles;

string[] carInput = Console.ReadLine().Split(' ').ToArray();
double carFuelQuantity = double.Parse(carInput[1]);
double carLitersPerKm = double.Parse(carInput[2]);

Car car = new Car(carFuelQuantity, carLitersPerKm);

string[] truckInput = Console.ReadLine().Split(' ').ToArray();
double truckFuelQuantity = double.Parse(truckInput[1]);
double truckLitersPerKm = double.Parse(truckInput[2]);

Truck truck = new Truck(truckFuelQuantity, truckLitersPerKm);

int commandsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < commandsCount; i++)
{
    string[] command = Console.ReadLine().Split(' ').ToArray();
    string action = command[0];
    string vehicle = command[1];

    if (action == "Drive")
    {
        double distance = double.Parse(command[2]);

        if (vehicle == "Car")
        {
            Console.WriteLine(car.Drive(distance));
        }
        else
        {
            Console.WriteLine(truck.Drive(distance));
        }
    }
    else
    {
        double liters = double.Parse(command[2]);

        if (vehicle == "Car")
        {
            car.Refuel(liters);
        }
        else
        {
            truck.Refuel(liters);
        }
    }
}

Console.WriteLine(car.GetVehicleWithFuelQuantity());
Console.WriteLine(truck.GetVehicleWithFuelQuantity());