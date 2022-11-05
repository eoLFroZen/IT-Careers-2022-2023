using System;

namespace D09_P07_Left_and_Right_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                //|10 - 15| = |-5| = 5
                //|15 - 10| = |5| = 5
                Console.WriteLine($"No, Diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
