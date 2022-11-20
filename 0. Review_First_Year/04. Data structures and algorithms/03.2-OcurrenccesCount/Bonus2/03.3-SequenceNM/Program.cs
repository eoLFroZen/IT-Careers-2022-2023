using _03._3_SequenceNM;

int[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int N = input[0];
int M = input[1];

if (M < N)
{
    Console.WriteLine("No solution found");
    return;
}

FindSolution(N, M);


// methods

void FindSolution(int N, int M)
{
    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(new Node(N));

    while(true)
    {
        Node firstElement = queue.Dequeue();

        if (firstElement.Value == M)
        {
            List<int> sequence = FindSequence(firstElement);
            Console.WriteLine(String.Join(" -> ", sequence));
            return;
        }

        queue.Enqueue(new Node(firstElement.Value + 1, firstElement));
        queue.Enqueue(new Node(firstElement.Value + 2, firstElement));
        queue.Enqueue(new Node(firstElement.Value * 2, firstElement));
    }
}

List<int> FindSequence(Node node)
{
    if (node.Previous is null)
    {
        return new List<int> { node.Value };
    }

    List<int> result = new List<int>();
    result.AddRange(FindSequence(node.Previous));
    result.Add(node.Value);

    return result;
}
