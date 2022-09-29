namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public string ID { get; }
        public string Model { get; }

        public Robot(string id, string model)
        {
            ID = id;
            Model = model;
        }
    }
}
