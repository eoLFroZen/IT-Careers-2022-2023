namespace AnimalKingdom
{
    public class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public string Perform()
        {
            return MakeNoise() + " " + MakeTrick();
        }
    }
}
