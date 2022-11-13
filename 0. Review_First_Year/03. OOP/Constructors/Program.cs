using Constructors;

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Person basePerson = new Person();
Person personWithAge = new Person(age);
Person personWithAgeAndName = new Person(name, age);

Console.WriteLine(basePerson);
Console.WriteLine(personWithAge);
Console.WriteLine(personWithAgeAndName);