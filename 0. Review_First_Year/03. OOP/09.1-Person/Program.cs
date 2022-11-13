using _09._1_Person;

int peopleCount = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();
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
        people.Add(person);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

//Console.WriteLine(string.Join('\n', people));

int percentage = int.Parse(Console.ReadLine());

foreach (var person in people)
{
    try
    {
        person.IncreaseSalary(percentage);
        Console.WriteLine(person);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        person.DecreaseSalary(percentage * 4);
        Console.WriteLine(person);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}