namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainMyself()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }
    }
}
