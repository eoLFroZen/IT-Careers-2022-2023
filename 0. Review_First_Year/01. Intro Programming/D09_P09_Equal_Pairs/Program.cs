using System;

namespace D09_P09_Equal_Pairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minSum = int.MaxValue;
            int maxSum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int currentSum = a + b;

                if (i == 0)
                {
                    minSum = currentSum;
                    maxSum = currentSum;
                }
                else
                {

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }

                    if (currentSum < minSum)
                    {
                        minSum = currentSum;
                    }
                }
            }

            int diff = maxSum - minSum;

            if (maxSum - minSum == 0)
            {
                Console.WriteLine($"Yes, value = {minSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff = {diff}");
            }
        }
    }
}
