namespace DesignPatternsCSharp.Creational.FactoryMethod
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
