namespace AnimalKingdom
{
    public abstract class Animal : IMakeNoise, IMakeTrick
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string MakeNoise()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public virtual string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
