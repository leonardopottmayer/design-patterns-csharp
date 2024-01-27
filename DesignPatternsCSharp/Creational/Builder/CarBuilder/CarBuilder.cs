namespace DesignPatternsCSharp.Creational.Builder.CarBuilder
{
    public class CarBuilder : IBuilder
    {
        private Car Car { get; set; }

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Car = new Car();
        }

        public void SetEngine(IEngine engine)
        {
            Car.Engine = engine;
        }

        public void SetGPS()
        {
            Car.HasGPS = true;
        }

        public void SetSeats(int seats)
        {
            Car.Seats = seats;
        }

        public void SetTripComputer()
        {
            Car.HasTripComputer = true;
        }

        public Car GetResult()
        {
            return Car;
        }
    }
}
