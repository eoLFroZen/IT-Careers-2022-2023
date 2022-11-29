using MiningSystem;

string input;

SystemManager manager = new SystemManager();

while ((input = Console.ReadLine()) != "Shutdown")
{
    List<string> arguments = input.Split()
        .ToList();

    string command = arguments[0];

    arguments = arguments.Skip(1)
        .ToList();
    string result = "";
    switch (command)
    {
        case "RegisterMiner":
            result = manager.RegisterMiner(arguments);
            break;
        case "RegisterProvider":
            result = manager.RegisterProvider(arguments);
            break;
        case "Day":
            result = manager.Day();
            break;
        case "Check":
            result = manager.Check(arguments);
            break;
    }

    Console.WriteLine(result);
}

Console.WriteLine(manager.ShutDown());