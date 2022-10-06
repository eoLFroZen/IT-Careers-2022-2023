int[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x))
    .ToArray();

int k = input.Length / 4;

int[] row1Part1 = input.Take(k).Reverse().ToArray();
int[] row1Part2 = input.Skip(3 * k).Reverse().ToArray();

int[] row1 = row1Part1.Concat(row1Part2).ToArray();

int[] row2 = input.Skip(k).Take(2 * k).ToArray();

int[] result = row1
    .Select((number, index) => number + row2[index])
    .ToArray();

Console.WriteLine(String.Join(" ", result));
