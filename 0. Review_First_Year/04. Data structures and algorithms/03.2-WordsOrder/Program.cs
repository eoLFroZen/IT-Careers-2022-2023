List<string> words = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

for (int i = 0; i < words.Count - 1; i++)
{
    for (int j = i + 1; j < words.Count; j++)
    {
        if (words[j].CompareTo(words[i]) < 0)
        {
            string buffer = words[j];
            words[j] = words[i];
            words[i] = buffer;
        }
    }
}

Console.WriteLine(String.Join(" ", words));