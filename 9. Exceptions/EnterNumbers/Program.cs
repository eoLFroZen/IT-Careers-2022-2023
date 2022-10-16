using EnterNumbers;

const int numbersCount = 10;
const int initialStart = 1;
const int initialEnd = 100;

int start = initialStart, end = initialEnd;
int[] numbers = new int[numbersCount];
for (int i = 0; i < numbersCount; i++)
{
    try
    {
        Console.WriteLine($"Please input a{i}:");
        numbers[i] = ReadNumber(start, end);
        start = numbers[i];
    }
    catch (InvalidNumberException ex)
    {
        Console.WriteLine(ex.Message);
        i--;
    }
}

static int ReadNumber(int start, int end)
{
    try
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= start || n >= end)
        {
            throw new InvalidNumberException($"The number was not in the interval ({start}, {end})");
        }

        return n;
    }
    catch (FormatException ex)
    {
        throw new InvalidNumberException("The given input was not a number", ex);
    }
}