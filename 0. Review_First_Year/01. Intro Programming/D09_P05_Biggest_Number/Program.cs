using System;

namespace D09_P05_Biggest_Number
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                maxNumber = maxNumber < num ? num : maxNumber;
            }

            Console.WriteLine(maxNumber);
        }
    }
}
