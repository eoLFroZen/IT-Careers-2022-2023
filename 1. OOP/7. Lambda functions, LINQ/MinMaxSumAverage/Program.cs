using System.Linq;

int numbersCount = int.Parse(Console.ReadLine());

int[] numbers = new int[numbersCount];
for (int i = 0; i < numbersCount; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int min = numbers.Min();
Console.WriteLine("Min: " + min);

int max = numbers.Max();
Console.WriteLine("Max: " + max);

int sum = numbers.Sum();
Console.WriteLine("Sum: " + sum);

double average = numbers.Average();
Console.WriteLine("Average: " + average);