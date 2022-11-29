namespace AnimalKingdom
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        string Perform();
    }
}
