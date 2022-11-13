using _10._1_Team;

string teamName = Console.ReadLine();
Team team = new Team(teamName);

int peopleCount = int.Parse(Console.ReadLine());
for (int i = 0; i < peopleCount; i++)
{
    List<string> input = Console.ReadLine().Split(' ').ToList();
    try
    {
        string firstName = input[0];
        string lastName = input[1];
        int age = int.Parse(input[2]);
        double salary = double.Parse(input[3]);

        Person person = new Person(firstName, lastName, age, salary);
        team.AddPerson(person);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine($"First team has {team.FirstTeam.Count} players");
Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");