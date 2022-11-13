using Static_Demo;

Console.WriteLine($"People count: {Person.PeopleCount}");

Person person = new Person("Maria", "Petrova", 18, 700);

Console.WriteLine($"People count: {Person.PeopleCount}");

person = new Person("Ivan", "Georgiev", 55, 1500);

Console.WriteLine($"People count: {Person.PeopleCount}");

Console.WriteLine($"2 + 3 = {Mathematics.Add(2, 3)}");
Console.WriteLine($"2 * 3 = {Mathematics.Multiply(2, 3)}");
Console.WriteLine($"Area of circle with r=4 is {Mathematics.CircleArea(4)}");