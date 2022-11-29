namespace P02_Royal_Gumbit
{
    public delegate void KingAttackEventHandler(object sender, EventArgs args);

    public class King : Person
    {
        private List<Servant> servants = new List<Servant>();

        public King(string name) : base(name) { }

        public event KingAttackEventHandler KingAttack;

        public void OnKingAttack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            if (KingAttack != null)
            {
                //KingAttack(this, EventArgs.Empty);
                KingAttack?.Invoke(this, EventArgs.Empty);
            }
        }

        public void AddServant(Servant servant)
        {
            KingAttack += servant.OnKingAttacked;
            this.servants.Add(servant);
        }
        public void RemoveServant(string name)
        {
            Servant servant = servants.FirstOrDefault(x => x.Name == name);
            if (servant != null)
            {
                KingAttack -= servant.OnKingAttacked;
                servants.Remove(servant);
            }
        }
    }
}
