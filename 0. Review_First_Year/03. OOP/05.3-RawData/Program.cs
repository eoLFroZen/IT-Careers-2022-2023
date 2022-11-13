using _05._3_RawData;

int N = int.Parse(Console.ReadLine());

//Car car = new Car("model", null, null, null);
//Console.WriteLine(car.ToString());

List<Car> cars = new List<Car>();
for (int i = 0; i < N; i++)
{
    List<string> carData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

    string model = carData[0];

    int engineSpeed = int.Parse(carData[1]);
    int enginePower = int.Parse(carData[2]);
    Engine engine = new Engine(engineSpeed, enginePower);

    int cargoWeight = int.Parse(carData[3]);
    string cargoType = carData[4];
    Cargo cargo = new Cargo(cargoWeight, cargoType);

    Tire[] tires = new Tire[4];
    for (int j = 0; j < 4; j++)
    {
        double tirePressure = double.Parse(carData[5 + 2 * j]);
        int tireAge = int.Parse(carData[6 + 2 * j]);
        tires[j] = new Tire(tirePressure, tireAge);
    }

    cars.Add(new Car(model, engine, cargo, tires));
}

string command = Console.ReadLine();

List<Car> filteredCars;
if (command == "fragile")
{
    filteredCars = cars
        .Where(car => car.Cargo.Type == "fragile" && car.Tires.All(tire => tire.Pressure < 1))
        .ToList();
}
else
{
    filteredCars = cars
        .Where(car => car.Cargo.Type == "flamable" && car.Engine.Power > 250)
        .ToList();
}

Console.WriteLine(string.Join('\n', filteredCars.Select(car => car.Model)));