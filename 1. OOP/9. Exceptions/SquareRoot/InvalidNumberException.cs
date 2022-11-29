namespace SquareRoot
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(Exception ex = null)
            : base("Invalid number", ex)
        {}
    }
}
