List<int> sequence1 = ReadNumbers();
List<int> sequence2 = ReadNumbers();

Console.WriteLine(String.Join(" ", Merge(sequence1, sequence2)));

// Methods:

IEnumerable<int> Merge(List<int> sequence1, List<int> sequence2)
{
    List<int> merged = new List<int>(sequence1.Count + sequence2.Count);
    int sequence1Index = 0, sequence2Index = 0;

    while (sequence1Index < sequence1.Count && sequence2Index < sequence2.Count)
    {
        if (sequence1[sequence1Index] < sequence2[sequence2Index])
        {
            merged.Add(sequence1[sequence1Index]);
            sequence1Index++;
        }
        else
        {
            merged.Add(sequence2[sequence2Index]);
            sequence2Index++;
        }
    }

    for (; sequence1Index < sequence1.Count; sequence1Index++)
    {
        merged.Add(sequence1[sequence1Index]);
    }

    for (; sequence2Index < sequence2.Count; sequence2Index++)
    {
        merged.Add(sequence2[sequence2Index]);
    }

    return merged;
}

List<int> ReadNumbers()
{
    return Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
}