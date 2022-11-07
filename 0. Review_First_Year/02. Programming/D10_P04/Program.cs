using System;
using System.Linq;

namespace D10_P04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 10 5 2
            // [ '10', '5', '2' ] - strings.
            // [ 10, 5, 2] - integers

            int[] arr = Console.ReadLine()
                .Split()
                .Select(s => int.Parse(s))
                .ToArray();

            while (arr.Length > 1)
            {
                int[] newArr = new int[arr.Length - 1];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newArr[i] = arr[i] + arr[i + 1];
                }

                arr = newArr;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
