namespace Transport.Model
{
    public class Train : Vehicle
    {
        public Train()
            : base(
                  Constants.TrainInitialPrice,
                  Constants.TrainPrice,
                  Constants.TrainPrice,
                  Constants.TrainMinKm)
        { }
    }
}
