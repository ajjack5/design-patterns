namespace DesignPatterns.Creational.Singleton.CSharp.Implementation
{
    public class Singleton
    {
        private static Singleton _Instance { get; set; }

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new Singleton();
            }

            return _Instance;
        }
    }
}
