namespace DesignPatternsCSharp.Creational.Builder.HouseBuilder
{
    public class HouseBuilder : IBuilder
    {
        public bool Walls { get; set; } = false;
        public bool Doors { get; set; } = false;
        public bool Windows { get; set; } = false;
        public bool Roof { get; set; } = false;
        public bool Garage { get; set; } = false;

        public HouseBuilder() { }

        public void Reset()
        {
            Walls = false;
            Doors = false;
            Windows = false;
            Roof = false;
            Garage = false;
        }

        public void BuildWalls()
        {
            Walls = true;
        }

        public void BuildDoors()
        {
            Doors = true;
        }

        public void BuildWindows()
        {
            Windows = true;
        }

        public void BuildRoof()
        {
            Roof = true;
        }

        public void BuildGarage()
        {
            Garage = true;
        }

        public House GetResult()
        {
            return new House(Walls, Doors, Windows, Roof, Garage);
        }
    }
}
