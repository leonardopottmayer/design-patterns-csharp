namespace DesignPatternsCSharp.Creational.Builder.HouseBuilder
{
    public class House
    {
        public bool Walls { get; set; }
        public bool Doors { get; set; }
        public bool Windows { get; set; }
        public bool Roof { get; set; }
        public bool? Garage { get; set; }

        public House(bool walls, bool doors, bool windows, bool roof, bool garage)
        {
            Walls = walls;
            Doors = doors;
            Windows = windows;
            Roof = roof;
            Garage = garage;
        }
    }
}
