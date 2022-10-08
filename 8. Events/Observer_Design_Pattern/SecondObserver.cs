namespace Observer_Design_Pattern
{
    public class SecondObserver : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Heyy from second");
        }
    }
}
