using System;

namespace D06_P04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(2 * a + 2 * b);
            Console.WriteLine(a * b);
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}
