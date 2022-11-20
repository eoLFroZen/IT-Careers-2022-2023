namespace DynamicList
{
    public class Node<T> where T : IComparable
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node(T value, Node<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
