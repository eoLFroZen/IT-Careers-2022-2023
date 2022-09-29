using BorderControl;

List<Robot> robots = new List<Robot>();
List<Citizen> citizens = new List<Citizen>();
List<Pet> pets = new List<Pet>();

string line = Console.ReadLine();
while (line != "End")
{
    var splittedLine = line.Split(' ').ToList();
    string type = splittedLine[0];
    switch (type)
    {
        case "Citizen":
        {
            string name = splittedLine[1];
            int age = int.Parse(splittedLine[2]);
            string id = splittedLine[3];
            string birthdate = splittedLine[4];

            Citizen citizen = new Citizen(id, name, age, birthdate);
            citizens.Add(citizen);

            break;
        }
        case "Robot":
        {
            string model = splittedLine[1];
            string id = splittedLine[2];

            Robot robot = new Robot(id, model);
            robots.Add(robot);

            break;
        }
        case "Pet":
        {
            string name = splittedLine[1];
            string birthdate = splittedLine[2];

            Pet pet = new Pet(name, birthdate);
            pets.Add(pet);

            break;
            }
    }

    line = Console.ReadLine();
}

string year = Console.ReadLine();

foreach (var citizen in citizens)
{
    if (citizen.Birthdate.EndsWith(year))
    {
        Console.WriteLine(citizen.Birthdate);
    }
}

foreach (var pet in pets)
{
    if (pet.Birthdate.EndsWith(year))
    {
        Console.WriteLine(pet.Birthdate);
    }
}




//List<Robot> robots = new List<Robot>();
//List<Citizen> citizens = new List<Citizen>();

//string line = Console.ReadLine();
//while (line != "End")
//{
//    var splittedLine = line.Split(' ').ToList();
//    if (splittedLine.Count == 2)
//    {
//        //robot
//        string model = splittedLine[0];
//        string id = splittedLine[1];
//        Robot robot = new Robot(id, model);
//        robots.Add(robot);
//    }
//    else
//    {
//        //citizen
//        string name = splittedLine[0];
//        int age = int.Parse(splittedLine[1]);
//        string id = splittedLine[2];
//        Citizen citizen = new Citizen(id, name, age);
//        citizens.Add(citizen);
//    }

//    line = Console.ReadLine();
//}

//string wrongIdSuffix = Console.ReadLine();

//foreach (var robot in robots)
//{
//    if (robot.ID.EndsWith(wrongIdSuffix))
//    {
//        Console.WriteLine(robot.ID);
//    }
//}

//foreach (var citizen in citizens)
//{
//    if (citizen.ID.EndsWith(wrongIdSuffix))
//    {
//        Console.WriteLine(citizen.ID);
//    }
//}