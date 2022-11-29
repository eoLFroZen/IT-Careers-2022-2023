using FilteredPeople;

int peopleCount = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();
for (int i = 0; i < peopleCount; i++)
{
    string[] input = Console.ReadLine().Split(' ').ToArray();
    string name = input[0];
    int age = int.Parse(input[1]);

    Person person = new Person(name, age);
    people.Add(person);
}

string[] filterInput = Console.ReadLine().Split(' ').ToArray();
string condition = filterInput[0];
int conditionAge = int.Parse(filterInput[1]);

Func<Person, string, int, bool> isPersonOkWithTheCondition = (person, condition, age) =>
{
    if (condition == "younger")
    {
        return person.Age < age;
    }

    return person.Age > age;
};

List<Person> filteredPeople = people
    .Where(person => isPersonOkWithTheCondition(person, condition, conditionAge))
    .ToList();

Action<Person, string> printPerson = (person, format) =>
{
    switch(format)
    {
        case "name":
            Console.WriteLine(person.Name);
            break;
        case "age":
            Console.WriteLine(person.Age);
            break;
        case "name age":
            Console.WriteLine(person.Name + " " + person.Age);
            break;
    }
};

string format = Console.ReadLine();

filteredPeople.ForEach(person => printPerson(person, format));