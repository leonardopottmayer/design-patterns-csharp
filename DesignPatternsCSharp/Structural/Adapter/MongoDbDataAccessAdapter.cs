namespace DesignPatternsCSharp.Structural.Adapter
{
    public class MongoDbDataAccessAdapter : IDataAccessAdapter
    {
        public ICollection<string> GetAllUsernames()
        {
            // Logic to query all usernames in MongoDB
            return new List<string>() { "user1", "user2", "user3" };
        }

        public void ConnectToDatabase()
        {
            // Logic to connect to the MongoDBDatabase database
        }
    }
}
