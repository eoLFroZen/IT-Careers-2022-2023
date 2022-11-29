using Animals;

List<Animal> animals = new List<Animal>();
animals.Add(new Cat("Ivet", "fish"));
animals.Add(new Dog("Sharo", "chicken"));
animals.Add(new Cat("Petar", "milk"));

foreach (Animal animal in animals)
{
    Console.WriteLine(animal.ExplainMyself());
}

Animal animal1 = new Cat("Valya", "fish");