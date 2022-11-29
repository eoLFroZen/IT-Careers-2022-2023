namespace BorderControl
{
    public class Citizen : IIdentifiable, ILiveCreature
    {
        public string ID { get; }
        public string Name { get; }
        public int Age { get; }

        public string Birthdate { get; }

        public Citizen(string id, string name, int age, string birthdate)
        {
            ID = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }
    }
}
