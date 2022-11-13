namespace _05._3_RawData
{
    public class Tire
    {
        public double Pressure { get; set; }

        public int Age { get; set; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
