namespace DesignPatternsCSharp.Creational.Builder.CarBuilder
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int seats);
        void SetEngine(IEngine engine);
        void SetTripComputer();
        void SetGPS();
    }
}
