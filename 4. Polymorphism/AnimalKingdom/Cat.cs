namespace AnimalKingdom
{
    public class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public string Perform()
        {
            return MakeNoise() + " " + MakeTrick();
        }
    }
}
