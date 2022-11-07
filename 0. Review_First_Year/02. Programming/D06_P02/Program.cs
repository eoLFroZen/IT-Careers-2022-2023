using System;

namespace D06_P02
{
    public class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(Math.PI * radius * radius, 12));
        }
    }
}
