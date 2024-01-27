namespace DesignPatternsCSharp.Creational.AbstractFactory
{
    internal class ModernChair : IChair
    {
        public bool HasLegs()
        {
            return false;
        }

        public void SitOn()
        {

        }
    }
}
