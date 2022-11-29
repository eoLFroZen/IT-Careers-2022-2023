using P02_Royal_Gumbit;

string kingsName = Console.ReadLine();
King king = new King(kingsName);

string[] royalGuardNames = Console.ReadLine().Split();
AddServants<RoyalGuard>(royalGuardNames, king);
//foreach (var name in royalGuardNames)
//{
//    king.AddServant(new RoyalGuard(name));
//}

string[] footmanNames = Console.ReadLine().Split();
AddServants<Footman>(footmanNames, king);
//foreach (var name in footmanNames)
//{
//    king.AddServant(new Footman(name));
//}

string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] splittedInput = input.Split();
    string command = splittedInput[0];

    switch (command)
    {
        case "Kill":
            string name = splittedInput[1];
            king.RemoveServant(name);
            break;
        case "Attack":
            king.OnKingAttack();
            break;
    }
}

void AddServants<T>(string[] names, King king)
    where T : Servant, new()
{
    foreach (string name in names)
    {
        T servant = new T();
        servant.Name = name;
        king.AddServant(servant);
    }
}