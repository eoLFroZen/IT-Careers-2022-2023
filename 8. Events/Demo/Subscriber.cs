namespace Demo
{
    public class Subscriber
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public void Test(string content)
        {
            Console.WriteLine($"{Name} - {Age}");
            Console.WriteLine($"{content}");
        }
    }
}
