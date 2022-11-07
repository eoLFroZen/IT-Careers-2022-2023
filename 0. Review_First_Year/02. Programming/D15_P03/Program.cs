using System;
using System.Collections.Generic;
using System.Linq;

namespace D15_P03
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(num => num > 0)
                .Reverse()
                .ToList();

            Console.WriteLine(numbers.Count != 0 ? string.Join(" ", numbers) : "Empty");
        }
    }
}
