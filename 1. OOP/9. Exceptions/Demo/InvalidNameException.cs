namespace Demo
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException()
            : base("The given name should contain at least 1 character")
        {}
    }
}
