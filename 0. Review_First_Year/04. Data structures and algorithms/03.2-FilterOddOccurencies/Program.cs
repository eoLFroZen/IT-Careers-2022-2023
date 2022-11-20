List<int> input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Dictionary<int, int> occurencyCount = new Dictionary<int, int>();
for (int i = 0; i < input.Count; i++)
{
    if (occurencyCount.ContainsKey(input[i]))
    {
        occurencyCount[input[i]]++;
    }
    else
    {
        //occurency.Add(input[i], 1);
        occurencyCount[input[i]] = 1;
    }
}

List<int> result = new List<int>();
for (int i = 0; i < input.Count; i++)
{
    if (occurencyCount[input[i]] % 2 == 0)
    {
        result.Add(input[i]);
    }
}

Console.WriteLine(String.Join(", ", result));