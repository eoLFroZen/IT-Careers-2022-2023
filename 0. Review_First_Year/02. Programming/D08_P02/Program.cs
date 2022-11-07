using System;

namespace D08_P02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<int> validNumber = new List<int>()
            //{
            //    5,7,11
            //};

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;

                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                //if (validNumber.Contains(sum))
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
