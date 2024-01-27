namespace DesignPatternsCSharp.Creational.FactoryMethod
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by truck.");
        }
    }
}
