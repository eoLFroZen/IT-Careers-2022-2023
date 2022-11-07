using System;
using System.Linq;

namespace D10_2_P04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToArray();

            int k = arr.Length / 4;

            int[] leftSide = arr.Take(k).Reverse().ToArray();
            int[] midSide = arr.Skip(k).Take(2 * k).ToArray();
            int[] rightSide = arr.Skip(3 * k).Take(k).Reverse().ToArray();

            int[] result = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftSide[i] + midSide[i];
                result[k + i] = rightSide[i] + midSide[k + i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
