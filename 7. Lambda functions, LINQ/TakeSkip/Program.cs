//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Console.WriteLine(string.Join(" ", numbers.Take(3).ToArray()));
//Console.WriteLine(string.Join(" ", numbers.Take(30).ToArray()));

//Console.WriteLine(string.Join(" ", numbers.Skip(3).ToArray()));

//Console.WriteLine(string.Join(" ", numbers.Skip(3).Take(2).ToArray()));

//int size = numbers.Count;
//Console.WriteLine(string.Join(" ", numbers.Skip(size / 2).Take(1).ToArray()));

double[] numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(n => double.Parse(n))
    .ToArray();

double[] biggestElements = numbers
    .OrderByDescending(n => n)
    .Take(3)
    .ToArray();

Console.WriteLine(String.Join(" ", biggestElements));

biggestElements = numbers
    .OrderBy(n => n)
    .Skip(numbers.Length - 3)
    .ToArray();

Console.WriteLine(String.Join(" ", biggestElements));