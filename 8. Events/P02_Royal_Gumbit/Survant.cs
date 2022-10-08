namespace P02_Royal_Gumbit
{
    public abstract class Servant : Person
    {
        public Servant() { }
        public Servant(string name) : base(name) { }

        public abstract void OnKingAttacked(object sender, EventArgs args);
    }
}
