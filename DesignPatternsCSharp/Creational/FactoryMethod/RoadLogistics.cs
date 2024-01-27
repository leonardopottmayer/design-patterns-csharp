namespace DesignPatternsCSharp.Creational.FactoryMethod
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
