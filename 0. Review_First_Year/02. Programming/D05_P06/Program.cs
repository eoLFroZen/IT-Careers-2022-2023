using System;

namespace D05_P06
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                result += firstNum % secondNum;
            }

            Console.WriteLine(result);
        }
    }
}
