namespace EnterNumbers
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message, Exception ex = null)
            : base(message, ex)
        {}
    }
}
