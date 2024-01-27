namespace DesignPatternsCSharp.Creational.Singleton
{
    public class Singleton
    {
        public List<string> SystemConstants { get; set; }

        private static Singleton _instance { get; set; }

        private Singleton()
        {
            SystemConstants = new List<string>();
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
