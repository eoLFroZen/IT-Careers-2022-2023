namespace DynamicList
{
    public class DynamicList<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public DynamicList()
        {
            size = 0;
        }

        public int Size => size;

        public void Add(T item)
        {
            size++;

            Node<T> newNode = new Node<T>(item);

            if (head is null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            tail.Next = newNode;
            tail = newNode;
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            Node<T> currentElement = head;
            Node<T> previousElement = null;

            for (int i = 0; i < index; i++)
            {
                previousElement = currentElement;
                currentElement = currentElement.Next;
            }

            RemoveElement(currentElement, previousElement);
            size--;

            return currentElement.Value;
        }

        public int Remove(T item)
        {
            Node<T> currentElement, previousElement;
            int index;

            (index, currentElement, previousElement) = FindElement(item);

            RemoveElement(currentElement, previousElement);
            size--;

            return index;
        }

        public int IndexOf(T item)
        {
            Node<T> currentElement, previousElement;
            int index;

            (index, currentElement, previousElement) = FindElement(item);

            return index;
        }

        public bool Contains(T item)
        {
            try
            {
                FindElement(item);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public T this[int index]
        {
            get
            {
                Node<T> element = GetElement(index);
                return element.Value;
            }

            set
            {
                Node<T> element = GetElement(index);
                element.Value = value;
            }
        }

        private void RemoveElement(Node<T> element, Node<T> previous)
        {
            if (previous is null)
            {
                head = element.Next;
            }
            else if (element.Next is null)
            {
                previous.Next = null;
                tail = previous;
            }
            else
            {
                previous.Next = element.Next;
            }
        }

        private (int index, Node<T> currentElement, Node<T> previousElement) FindElement(T value)
        {
            Node<T> currentElement = head;
            Node<T> previousElement = null;
            int index = 0;

            while (currentElement != null && !currentElement.Value.Equals(value))
            {
                previousElement = currentElement;
                currentElement = currentElement.Next;
                index++;
            }

            if (currentElement is null)
            {
                throw new ArgumentException("Element not found");
            }

            return (index, currentElement, previousElement);
        }

        private Node<T> GetElement(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> currentElement = head;
            for (int i = 0; currentElement != null && i < index; i++)
            {
                currentElement = currentElement.Next;
            }

            return currentElement;
        }
    }
}
