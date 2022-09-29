namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public void Call(string phoneNumber)
        {
            if (phoneNumber.Count(character => character < '0' || character > '9') > 0)
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine($"Calling... {phoneNumber}");
        }

        public void Browse(string url)
        {
            if (url.Count(character => character >= '0' && character <= '9') > 0)
            {
                Console.WriteLine("Invalid URL!");
                return;
            }

            Console.WriteLine($"Browsing: {url}");
        }
    }
}
