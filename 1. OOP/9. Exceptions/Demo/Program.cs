using Demo;

static string InputName()
{
    string name = Console.ReadLine();
    if (string.IsNullOrEmpty(name))
    {
        throw new InvalidNameException();
    }

    return name;
}

static int InputAge()
{
    try
    {
        int age = int.Parse(Console.ReadLine());
        if (age < 1 || age > 120)
        {
            throw new OverflowException("Age was not between 1 and 120 years");
        }

        return age;
    }
    catch (FormatException exception)
    {
        throw new InvalidAgeException(exception);
    }
    catch (OverflowException exception)
    {
        throw new InvalidAgeException(exception);
    }
}

static void CreatePerson()
{
    Person person = new Person();
    person.Name = InputName();
    person.Age = InputAge();
}


CreatePerson();

Console.WriteLine("End");