List<int> sequence = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < sequence.Count; i++)
{
    if (sequence[i] < 0)
    {
        sequence.RemoveAt(i);
        i--;
    }
}

Console.WriteLine(String.Join(" ", sequence));