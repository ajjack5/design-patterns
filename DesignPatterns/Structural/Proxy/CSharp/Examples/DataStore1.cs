namespace DesignPatterns.Structural.Proxy.CSharp.Examples
{
    public class DataStore1 : IDataStore
    {
        private readonly IDataStore _DataStore;

        public DataStore1(IDataStore dataStore)
        {
            _DataStore = dataStore;
        }

        public string SaveData(string data)
        {
            return "DataStore1" + _DataStore.SaveData(data);
        }
    }
}
