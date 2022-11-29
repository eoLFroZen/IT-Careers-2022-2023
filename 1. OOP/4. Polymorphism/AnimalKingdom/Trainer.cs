namespace AnimalKingdom
{
    public class Trainer
    {
        public IAnimal Animal { get; set; }

        public Trainer(IAnimal animal)
        {
            Animal = animal;
        }

        public string Make()
        {
            return Animal.Perform();
        }
    }
}
