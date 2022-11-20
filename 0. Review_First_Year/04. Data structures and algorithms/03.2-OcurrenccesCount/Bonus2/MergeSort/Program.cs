List<int> array = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Sort(array, 0, array.Count);

Console.WriteLine(String.Join(" ", array));



void Sort(List<int> array, int from, int to)
{
    if (to - from == 1)
    {
        return;
    }

    int middle = (from + to) / 2;

    Sort(array, from, middle);
    Sort(array, middle, to);

    Merge(array, from, middle, to);
}

void Merge(List<int> array, int from, int middle, int to)
{
    List<int> result = new List<int>(to - from);
    int index1 = from, index2 = middle;
    while(index1 < middle && index2 < to)
    {
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
        array[i] = result[i - from];
    }
}

