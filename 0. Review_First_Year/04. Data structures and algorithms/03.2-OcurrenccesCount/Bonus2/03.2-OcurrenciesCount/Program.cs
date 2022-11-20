List<int> input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Dictionary<int, int> occurrencesCount = new Dictionary<int, int>();
for (int i = 0; i < input.Count; i++)
{
    if (occurrencesCount.ContainsKey(input[i]))
    {
        occurrencesCount[input[i]]++;
    }
    else
    {
        //occurency.Add(input[i], 1);
        occurrencesCount[input[i]] = 1;
    }
}

foreach (var element in occurrencesCount.OrderBy(element => element.Key))
{
    Console.WriteLine($"{element.Key} - {element.Value} times");
}