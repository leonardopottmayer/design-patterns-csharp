namespace DesignPatternsCSharp.Creational.Builder.CarBuilder
{
    public class CarBuilderTest
    {
        public void Run()
        {
            var director = new Director();
            var carBuilder = new CarBuilder();

            director.MakeSportsCar(carBuilder);

            Car sportsCar = carBuilder.GetResult();
        }
    }
}
