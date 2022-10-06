using OrderBy;

Person[] people = new Person[]
{
    new Person("Angel", 50),
    new Person("Zahari", 10),
    new Person("Dimitar", 10),
    new Person("Maria", 10),
    new Person("Didi", 50),
    new Person("Angela", 50)
};

Person[] sortedPeople = people
    .OrderBy((Person person) => { return person.Age; })
    .ThenBy(person => person.Name)
    .ToArray();

foreach(var person in sortedPeople)
{
    Console.WriteLine(person.Name + ' ' + person.Age);
}
