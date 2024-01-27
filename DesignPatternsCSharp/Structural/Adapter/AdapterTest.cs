namespace DesignPatternsCSharp.Structural.Adapter
{
    public class AdapterTest
    {
        public void Run()
        {
            IDataAccessAdapter dataAccessAdapter = GetDataAccess();

            ICollection<string> usernames = dataAccessAdapter.GetAllUsernames();
        }

        private IDataAccessAdapter GetDataAccess()
        {
            //return new MongoDbDataAccessAdapter();
            return new MySqlDataAccessAdapter();
        }
    }
}
