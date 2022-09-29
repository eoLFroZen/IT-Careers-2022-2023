namespace Citizens
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private int age;

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; }

        public string Birthdate { get; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
