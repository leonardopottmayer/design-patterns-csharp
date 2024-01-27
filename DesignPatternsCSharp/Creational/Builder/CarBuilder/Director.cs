namespace DesignPatternsCSharp.Creational.Builder.CarBuilder
{
    public class Director
    {
        public Director() { }

        public void MakeSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(5);
            builder.SetEngine(new SUVEngine());
            builder.SetTripComputer();
            builder.SetGPS();
        }

        public void MakeSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new SportEngine());
            builder.SetTripComputer();
            builder.SetGPS();
        }
    }
}
