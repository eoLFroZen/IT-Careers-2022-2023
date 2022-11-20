int[] fabricsLength = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] timeInput = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int compareTime = timeInput[0];
int swapTime = timeInput[1];

int[] workInput = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int compareWork = workInput[0];
int swapWork = workInput[1];

int compareSum = compareTime + compareWork;
int swapSum = swapTime + swapWork;

int compareCount, swapCount;
if (compareSum < swapSum)
{
    (compareCount, swapCount) = SelectionSort(fabricsLength);
}
else
{
    (compareCount, swapCount) = MergeSort(fabricsLength, 0, fabricsLength.Length);
}

Console.WriteLine($"{compareCount} {swapCount}");

int time = compareTime * compareCount + swapTime * swapCount;
int work = compareWork * compareCount + swapWork * swapCount;
Console.WriteLine($"{time} {work}");



// Selection sort
(int compareCount, int swapCount) SelectionSort(int[] array)
{
    int compareCount = 0, swapCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int smallerIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            compareCount++;
            if (array[j] < array[smallerIndex])
            {
                smallerIndex = j;
            }
        }

        if (smallerIndex != i)
        {
            swapCount++;
            Swap(ref array[i], ref array[smallerIndex]);
        }
    }

    return (compareCount, swapCount);
}

void Swap(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;
}

// Merge sort
(int compareCount, int swapCount) MergeSort(int[] array, int from, int to)
{
    if (to - from == 1)
    {
        return (0, 0);
    }

    int middle = (from + to) / 2;

    int compareCount = 0, swapCount = 0;
    int currentCompareCount = 0, currentSwapCount = 0;

    (currentCompareCount, currentSwapCount) = MergeSort(array, from, middle);
    compareCount += currentCompareCount;
    swapCount += currentSwapCount;

    (currentCompareCount, currentSwapCount) = MergeSort(array, middle, to);
    compareCount += currentCompareCount;
    swapCount += currentSwapCount;

    (currentCompareCount, currentSwapCount) = Merge(array, from, middle, to);
    compareCount += currentCompareCount;
    swapCount += currentSwapCount;

    return (compareCount, swapCount);
}

(int compareCount, int swapCount) Merge(int[] array, int from, int middle, int to)
{
    int compareCount = 0, swapCount = 0;
    List<int> result = new List<int>(to - from);
    int index1 = from, index2 = middle;
    while (index1 < middle && index2 < to)
    {
        compareCount++;
        if (array[index1] <= array[index2])
        {
            result.Add(array[index1]);
            index1++;
        }
        else
        {
            result.Add(array[index2]);
            index2++;
        }
    }

    for (; index1 < middle; index1++)
    {
        result.Add(array[index1]);
    }

    for (; index2 < to; index2++)
    {
        result.Add(array[index2]);
    }

    for (int i = from; i < to; i++)
    {
        if (array[i] != result[i - from])
        {
            swapCount++;
        }

        array[i] = result[i - from];
    }

    return (compareCount, swapCount);
}