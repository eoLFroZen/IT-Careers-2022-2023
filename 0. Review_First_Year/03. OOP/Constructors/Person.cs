namespace Constructors
{    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Accounts;

        public Person(string name, int age, List<string> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        public Person(string name, int age)
            : this(name, age, new List<string>())
        { }

        public Person()
            : this("No name", 1)
        { }

        public Person(int age)
            : this("No name", age)
        { }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
