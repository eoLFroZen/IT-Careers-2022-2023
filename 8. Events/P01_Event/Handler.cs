namespace P01_Event
{
    public class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Dispatcher’s name changed from {args.OldName} to {args.Name}");
        }
    }
}
