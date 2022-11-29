Func<string, int> intParser = numberString =>
{
    int number = 0;
    for (int i = 0; i < numberString.Length; i++)
    {
        int currentDigit = numberString[i] - '0';
        number = number * 10 + currentDigit;
    }

    return number;
};

int[] numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(intParser)
    .ToArray();

Console.WriteLine(String.Join(" ", numbers));

Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.Sum());
