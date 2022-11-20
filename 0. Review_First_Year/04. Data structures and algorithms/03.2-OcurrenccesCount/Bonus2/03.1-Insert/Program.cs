List<int> sequence = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int elementToInsert = int.Parse(Console.ReadLine());

int[] newSequence = new int[sequence.Count + 1];
int i;
for (i = 0; i < sequence.Count && elementToInsert > sequence[i]; i++) 
{
    newSequence[i] = sequence[i];
}

newSequence[i] = elementToInsert;

for (i++; i <= sequence.Count; i++)
{
    newSequence[i] = sequence[i - 1];
}

Console.WriteLine(String.Join(" ", sequence));
Console.WriteLine(String.Join(" ", newSequence));