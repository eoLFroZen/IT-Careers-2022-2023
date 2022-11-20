const int minNumber = 10;
const int maxNumber = 99; 

int[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] occurrencesCount = new int[maxNumber - minNumber + 1];

for (int i = 0; i < input.Length; i++)
{
    occurrencesCount[input[i] - minNumber]++;
}

int maxOccurenciesIndex = 0;
for (int i = 1; i < occurrencesCount.Length; i++)
{
    if (occurrencesCount[i] >= occurrencesCount[maxOccurenciesIndex])
    {
        maxOccurenciesIndex = i;
    }
}

int occurencies = occurrencesCount[maxOccurenciesIndex];
int number = maxOccurenciesIndex + minNumber;
Console.WriteLine($"{occurencies} {number}");