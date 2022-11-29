using Family;

int N = int.Parse(Console.ReadLine());

Family.Family family = new Family.Family();
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    string name = input[0];
    int age = int.Parse(input[1]);

    Person person = new Person(name, age);
    family.AddMember(person);
}

family.Print();