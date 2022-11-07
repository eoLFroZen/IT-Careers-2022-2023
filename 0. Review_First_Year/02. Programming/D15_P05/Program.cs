using System;
using System.Collections.Generic;
using System.Linq;

namespace D15_P05
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
               .Split()
               .Select(s => int.Parse(s))
               .ToList();

            List<int> bombArgs = Console.ReadLine()
                .Split()
                .Select(s => int.Parse(s))
                .ToList();

            int bomb = bombArgs[0];
            int range = bombArgs[1];

            while (ints.Contains(bomb))
            {
                // 4 bomb, 2 range;
                // [ 1 2 3 4 5 6 7]

                // bomb 2, 5 range;
                // [1 2 3]


                int bombIndex = ints.FindIndex(num => num == bomb);
                int startIndex = bombIndex - range;
                int count = 2 * range + 1;

                if (startIndex < 0)
                {
                    count -= Math.Abs(startIndex);
                    startIndex = 0;
                }

                int rightIndex = bombIndex + range;

                if (ints.Count - rightIndex < 0)
                {
                    count -= rightIndex + 1 - ints.Count;
                }

                ints.RemoveRange(startIndex, count);
            }

            Console.WriteLine(ints.Sum());
        }
    }
}
