namespace DesignPatternsCSharp.Creational.FactoryMethod
{
    public class FactoryMethodTest
    {
        public void Run()
        {
            var roadLogistics = new RoadLogistics();

            ITransport roadTransport = roadLogistics.CreateTransport();
            roadTransport.Deliver();

            var seaLogistics = new SeaLogistics();

            ITransport seaTransport = seaLogistics.CreateTransport();
            seaTransport.Deliver();
        }
    }
}
