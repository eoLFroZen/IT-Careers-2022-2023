List<int> sequence = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int searchValue = int.Parse(Console.ReadLine());

if (BinarySearch(sequence, searchValue, 0, sequence.Count - 1))
{
    Console.WriteLine($"{searchValue} exists in the Array");
}
else
{
    Console.WriteLine($"{searchValue} doesn't exis in the Array");
}

// iterative solution
//int left = 0, right = sequence.Count - 1;
//while(left <= right)
//{
//    int middle = (left + right) / 2;

//    if (sequence[middle] == searchValue)
//    {
//        Console.WriteLine($"{searchValue} exists in the Array");
//        return;
//    }

//    if (sequence[middle] < searchValue)
//    {
//        left = middle + 1;
//    }
//    else
//    {
//        right = middle - 1;
//    }
//}

//Console.WriteLine($"{searchValue} doesn't exis in the Array");


bool BinarySearch(List<int> elements, int searchValue, int left, int right)
{
    if (left > right)
    {
        return false;
    }

    int middle = (left + right) / 2;

    if (elements[middle] == searchValue)
    {
        return true;
    }

    if (elements[middle] > searchValue)
    {
        return BinarySearch(elements, searchValue, left, middle - 1);
    }

    return BinarySearch(elements, searchValue, middle + 1, right);
}