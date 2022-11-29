using AnimalKingdom;

Cat cat = new Cat();
Trainer trainer = new Trainer(cat);

Console.WriteLine(trainer.Make());

Dog dog = new Dog();
trainer.Animal = dog;

Console.WriteLine(trainer.Make());