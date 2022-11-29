using System.Linq;

int[] numbers = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int[] result = numbers
    .Where((int number) => 
    {
        return number % 2 == 1; 
    })
    .OrderBy(number => number)
    .ToArray();

Console.WriteLine(String.Join(", ", result));

int Func(int number)
{
    return number;
}