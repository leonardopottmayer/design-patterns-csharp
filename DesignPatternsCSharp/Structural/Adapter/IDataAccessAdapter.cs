namespace DesignPatternsCSharp.Structural.Adapter
{
    public interface IDataAccessAdapter
    {
        ICollection<string> GetAllUsernames();
        void ConnectToDatabase();
    }
}
