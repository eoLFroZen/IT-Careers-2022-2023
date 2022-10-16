namespace Demo
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(Exception innerException)
            : base("The given age was not in the correct format, it should be a number between 1 and 120",
                  innerException)
        {}
    }
}
