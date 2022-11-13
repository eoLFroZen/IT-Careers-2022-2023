namespace _10._1_Team
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return name; }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Team name must have at least 3 symbols.");
                }

                name = value;
            }
        }

        public void AddPerson(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public IReadOnlyCollection<Person> FirstTeam
            => firstTeam.AsReadOnly();

        public IReadOnlyCollection<Person> ReserveTeam
            => reserveTeam.AsReadOnly();
    }
}
