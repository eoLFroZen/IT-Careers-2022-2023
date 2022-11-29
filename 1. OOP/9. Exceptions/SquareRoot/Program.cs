using SquareRoot;

try
{
    int n;
    try
    {
        n = int.Parse(Console.ReadLine());
    }
    catch (FormatException ex)
    {
        throw new InvalidNumberException(ex);
    }

    if (n < 0)
    {
        throw new InvalidNumberException();
    }

    double squareRoot = Math.Sqrt(n);
    Console.WriteLine(squareRoot);
}
catch (InvalidNumberException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Good bye");
}