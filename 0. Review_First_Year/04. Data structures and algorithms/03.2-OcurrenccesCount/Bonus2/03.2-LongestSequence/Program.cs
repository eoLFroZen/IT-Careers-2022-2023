List<int> input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int sequenceElement = input[0], sequenceCount = 0, currentCount = 0;
for (int i = 0; i < input.Count; i++)
{
    if (i > 0 && input[i] != input[i - 1])
    {
        if (currentCount > sequenceCount)
        {
            sequenceCount = currentCount;
            sequenceElement = input[i - 1];
        }

        currentCount = 1;
    }
    else
    {
        currentCount++;
    }
}

if (currentCount > sequenceCount)
{
    sequenceCount = currentCount;
    sequenceElement = input[input.Count - 1];
}

List<int> result = new List<int>();
for (int i = 0; i < sequenceCount; i++)
{
    result.Add(sequenceElement);
}

Console.WriteLine(String.Join(" ", result));