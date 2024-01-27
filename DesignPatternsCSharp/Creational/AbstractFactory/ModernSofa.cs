namespace DesignPatternsCSharp.Creational.AbstractFactory
{
    public class ModernSofa : ISofa
    {
        public decimal GetWidth()
        {
            return 1.56M;
        }

        public bool HasLegs()
        {
            return false;
        }

        public void SitOn()
        {

        }
    }
}
