namespace AnimalKingdom
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeNoise()
        {
            return "Woof! " + base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}
