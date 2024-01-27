namespace DesignPatternsCSharp.Creational.AbstractFactory
{
    public class VictorianSofa : ISofa
    {
        public decimal GetWidth()
        {
            return 2.0M;
        }

        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {

        }
    }
}
