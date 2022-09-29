using Statistic;

int N = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    string name = input[0];
    int age = int.Parse(input[1]);

    Person person = new Person(name, age);
    people.Add(person);
}

List<Person> peopleOlderThan30 = people
    .Where(person => person.Age > 30)
    .OrderBy(person => person.Name)
    .ToList();

foreach (var person in peopleOlderThan30)
{
    Console.WriteLine(person);
}