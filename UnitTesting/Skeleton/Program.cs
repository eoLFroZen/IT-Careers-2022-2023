Axe axe1 = new Axe(10, 10);
Hero hero1 = new Hero("Ivan", axe1);

Console.WriteLine(hero1.Weapon.AttackPoints + " " + hero1.Weapon.DurabilityPoints);

Knife knife = new Knife(100, 5);
Hero hero2 = new Hero("Georgi", knife);

Console.WriteLine(hero2.Weapon.AttackPoints + " " + hero2.Weapon.DurabilityPoints);