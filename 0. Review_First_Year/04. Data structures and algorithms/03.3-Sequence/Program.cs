int firstMember = int.Parse(Console.ReadLine());

Queue<int> queue = new Queue<int>();
queue.Enqueue(firstMember);

const int sequenceCount = 50;
List<int> sequence = new List<int>(sequenceCount);
for (int i = 0; i < sequenceCount; i++)
{
    firstMember = queue.Dequeue();

    sequence.Add(firstMember);

    queue.Enqueue(firstMember + 1);
    queue.Enqueue(2 * firstMember + 1);
    queue.Enqueue(firstMember + 2);
}

Console.WriteLine(String.Join(", ", sequence));