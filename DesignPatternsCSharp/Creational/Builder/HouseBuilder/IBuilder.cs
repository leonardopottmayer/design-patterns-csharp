namespace DesignPatternsCSharp.Creational.Builder.HouseBuilder
{
    public interface IBuilder
    {
        public void Reset();
        public void BuildWalls();
        public void BuildDoors();
        public void BuildWindows();
        public void BuildRoof();
        public void BuildGarage();
        House GetResult();
    }
}
