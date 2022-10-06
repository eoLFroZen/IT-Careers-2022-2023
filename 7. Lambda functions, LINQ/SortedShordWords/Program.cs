List<string> sortedShortWords = Console.ReadLine()
    .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' },
        StringSplitOptions.RemoveEmptyEntries)
    .Where(x => x.Length < 5)
    .Select(x => x.ToLower())
    .Distinct()
    .OrderBy(x => x)
    .ToList();

Console.WriteLine(String.Join(", ", sortedShortWords));