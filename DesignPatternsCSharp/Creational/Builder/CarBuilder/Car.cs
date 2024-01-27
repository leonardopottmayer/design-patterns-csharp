namespace DesignPatternsCSharp.Creational.Builder.CarBuilder
{
    public class Car
    {
        public int Seats { get; set; }
        public IEngine Engine { get; set; }
        public bool HasTripComputer { get; set; }
        public bool HasGPS { get; set; }

        public Car() { }

        public Car(int seats, IEngine engine, bool hasTripComputer, bool hasGPS)
        {
            Seats = seats;
            Engine = engine;
            HasTripComputer = hasTripComputer;
            HasGPS = hasGPS;
        }
    }
}
