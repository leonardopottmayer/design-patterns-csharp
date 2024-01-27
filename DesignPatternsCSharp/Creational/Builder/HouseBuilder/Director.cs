namespace DesignPatternsCSharp.Creational.Builder.HouseBuilder
{
    public class Director
    {
        private IBuilder Builder { get; set; }

        public Director(IBuilder builder)
        {
            Builder = builder;
        }

        public void ChangeBuilder(IBuilder builder)
        {
            Builder = builder;
        }

        public House Construct(HouseType type)
        {
            Builder.BuildWalls();
            Builder.BuildDoors();
            Builder.BuildWindows();
            Builder.BuildRoof();

            if (type == HouseType.Big)
            {
                Builder.BuildGarage();
            }

            return Builder.GetResult();
        }
    }
}
