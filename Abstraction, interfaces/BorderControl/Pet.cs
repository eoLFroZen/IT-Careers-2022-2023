namespace BorderControl
{
    public class Pet : ILiveCreature
    {
        public string Name { get; }
        public string Birthdate { get; }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
