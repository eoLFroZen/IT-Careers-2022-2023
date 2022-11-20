int[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int inversionsCount = 0;
for (int i = 0; i < input.Length - 1; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] > input[j])
        {
            inversionsCount++;
        }
    }
}

Console.WriteLine(inversionsCount);