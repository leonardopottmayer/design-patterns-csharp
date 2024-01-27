namespace DesignPatternsCSharp.Creational.Builder.CarBuilder
{
    public class ManualBuilder : IBuilder
    {
        private Manual Manual { get; set; }

        public ManualBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Manual = new Manual();
        }

        public void SetEngine(IEngine engine)
        {
            Manual.Engine = engine;
        }

        public void SetGPS()
        {
            Manual.HasGPS = true;
        }

        public void SetSeats(int seats)
        {
            Manual.Seats = seats;
        }

        public void SetTripComputer()
        {
            Manual.HasTripComputer = true;
        }

        public Manual GetResult()
        {
            return Manual;
        }
    }
}
