using System;

namespace D05_P04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            //int tempNum = a;
            //a = b;
            //b = tempNum;

            Console.WriteLine($"After: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
