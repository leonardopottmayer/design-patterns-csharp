namespace DesignPatternsCSharp.Creational.Builder.HouseBuilder
{
    public class HouseBuilderTest
    {
        public void Run()
        {
            var houseBuilder = new HouseBuilder();

            var director = new Director(houseBuilder);

            House bigHouse = director.Construct(HouseType.Big);
            House simpleHouse = director.Construct(HouseType.Simple);
        }
    }
}
