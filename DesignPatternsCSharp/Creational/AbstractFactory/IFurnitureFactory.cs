namespace DesignPatternsCSharp.Creational.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
