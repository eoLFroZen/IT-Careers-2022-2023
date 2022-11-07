using System;
using System.Linq;

namespace D10_2_P03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(s => int.Parse(s))
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] resultArr = new int[arr.Length];

            for (int i = 0; i < rotations; i++)
            {
                int[] newArr = new int[arr.Length];

                // First Approach
                //for (int j = 0; j < arr.Length; j++)
                //{
                //    if (j == 0)
                //    {
                //        newArr[j] = arr[arr.Length - 1];
                //    }
                //    else
                //    {
                //        newArr[j] = arr[j - 1];
                //    }
                //}

                // Second Approach
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    newArr[j + 1] = arr[j];
                }

                newArr[0] = arr[arr.Length - 1];
                // --------------------------------------- //

                arr = newArr;

                for (int j = 0; j < arr.Length; j++)
                {
                    resultArr[j] = resultArr[j] + newArr[j];
                }
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
