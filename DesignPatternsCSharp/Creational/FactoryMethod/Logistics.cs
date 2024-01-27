namespace DesignPatternsCSharp.Creational.FactoryMethod
{
    public abstract class Logistics
    {
        public virtual void PlanDelivery()
        {
            Console.WriteLine("Planning delivery...");
        }

        public abstract ITransport CreateTransport();
    }
}
