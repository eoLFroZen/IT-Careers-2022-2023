using System;

namespace D05_P03
{
    public class Program
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(numInHex, 16));
        }
    }
}
