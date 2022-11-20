List<int> input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Stack<int> stack = new Stack<int>();
for (int i = 0; i < input.Count; i++)
{
    stack.Push(input[i]);
}

while(stack.Count > 0)
{
    int topElement = stack.Pop();
    Console.Write($"{topElement} ");
}