namespace Observer_Design_Pattern
{
    public class Subject
    {
        private ICollection<IObserver> _observers = new List<IObserver>();

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                NotifyObservers();
            }
        }


        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Notify();
            }
        }
    }
}
