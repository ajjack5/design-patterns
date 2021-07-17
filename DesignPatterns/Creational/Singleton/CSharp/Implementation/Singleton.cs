namespace DesignPatterns.Creational.Singleton.CSharp.Implementation
{
    public class Singleton
    {
        private static Singleton Instance { get; set; }

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }
    }
}
