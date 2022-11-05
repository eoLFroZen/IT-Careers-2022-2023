using System;

namespace D09_P04_Sum_of_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                result += num;
            }

            Console.WriteLine(result);
        }
    }
}
