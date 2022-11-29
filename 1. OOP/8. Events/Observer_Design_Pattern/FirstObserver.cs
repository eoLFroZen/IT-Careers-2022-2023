namespace Observer_Design_Pattern
{
    public class FirstObserver : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Heyy from first");
        }
    }
}
