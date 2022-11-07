using System;

namespace D06_P03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                result += number;
            }

            Console.WriteLine(result);
        }
    }
}
