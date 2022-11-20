namespace _03._3_SequenceNM
{
    public class Node
    {
        public int Value { get; set; }

        public Node Previous { get; set; }

        public Node(int value, Node previous = null)
        {
            Value = value;
            Previous = previous;
        }
    }
}
