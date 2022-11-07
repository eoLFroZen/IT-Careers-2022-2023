using System;
using System.Collections.Generic;
using System.Linq;

namespace D15_P04
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<string> result = string.Join(" ", numbers)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
