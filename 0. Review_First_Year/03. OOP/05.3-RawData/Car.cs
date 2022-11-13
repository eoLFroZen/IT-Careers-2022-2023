using System.Text;

namespace _05._3_RawData
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires;

        public Car(
            string model,
            int engineSpeed, int enginePower,
            int cargoWeight, string cargoType,
            double tire1Pressure, int tire1Age,
            double tire2Pressure, int tire2Age,
            double tire3Pressure, int tire3Age,
            double tire4Pressure, int tire4Age)
            : this(
                  model,
                  new Engine(engineSpeed, enginePower),
                  new Cargo(cargoWeight, cargoType),
                  new Tire(tire1Pressure, tire1Age),
                  new Tire(tire2Pressure, tire2Age),
                  new Tire(tire3Pressure, tire3Age),
                  new Tire(tire4Pressure, tire4Age))
        { }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public Car(
            string model,
            Engine engine,
            Cargo cargo,
            Tire tire1,
            Tire tire2,
            Tire tire3,
            Tire tire4)
            : this(model, engine, cargo, new Tire[4] { tire1, tire2, tire3, tire4 })
        { }

        //public override string ToString()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    stringBuilder.AppendLine("AppendLine 1");
        //    stringBuilder.Append("23");
        //    stringBuilder.Append("456");

        //    return stringBuilder.ToString();
        //}
    }
}
