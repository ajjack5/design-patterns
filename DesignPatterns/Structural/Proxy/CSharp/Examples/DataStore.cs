namespace DesignPatterns.Structural.Proxy.CSharp.Examples
{
    public class DataStore : IDataStore
    {
        public string SaveData(string data)
        {
            return $"{data} has been saved";
        }
    }
}
