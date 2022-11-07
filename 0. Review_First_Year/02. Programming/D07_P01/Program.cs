using System;

namespace D07_P01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = peopleCount / capacity;

            if (peopleCount % capacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
