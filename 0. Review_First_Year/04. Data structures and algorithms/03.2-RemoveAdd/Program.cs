List<int> input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int element = int.Parse(Console.ReadLine());

List<int> result = new List<int>();
bool elementAddedOrDeleted = false;

// Solution 1
//for (int inputIndex = 0; inputIndex < input.Count; inputIndex++)
//{
//    if (input[inputIndex] < element)
//    {
//        result.Add(input[inputIndex]);
//    }
//    else if (input[inputIndex] == element)
//    {
//        elementAddedOrDeleted = true;
//    }
//    else
//    {
//        if (!elementAddedOrDeleted)
//        {
//            result.Add(element);
//            elementAddedOrDeleted = true;
//        }
//        result.Add(input[inputIndex]);
//    }
//}

//if (!elementAddedOrDeleted)
//{
//    result.Add(element);
//}

// Solution 2
int inputIndex = 0;
for (; inputIndex < input.Count && input[inputIndex] < element; inputIndex++)
{
    result.Add(input[inputIndex]);
}

if (inputIndex == input.Count || input[inputIndex] > element)
{
    result.Add(element);
}
else
{
    inputIndex++;
}

for (; inputIndex < input.Count; inputIndex++)
{
    result.Add(input[inputIndex]);
}

Console.WriteLine(String.Join(" ", result));
