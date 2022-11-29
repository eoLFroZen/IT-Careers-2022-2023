namespace P02_Royal_Gumbit
{
    public class RoyalGuard : Servant
    {
        public RoyalGuard() { }

        public RoyalGuard(string name) : base(name) { }

        public override void OnKingAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
