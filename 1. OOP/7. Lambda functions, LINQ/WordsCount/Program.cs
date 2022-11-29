string input = Console.ReadLine();

Func<string, bool> startsWithUppercaseLetter = word => word[0] >= 'A' && word[0] <= 'Z';

Action<string> print = s => Console.WriteLine(s);

input
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Where(startsWithUppercaseLetter)
    .ToList()
    .ForEach(print);