namespace DesignPatterns.Structural.Proxy.CSharp.Examples
{
    public class DataStore2 : IDataStore
    {
        private readonly IDataStore _DataStore;

        public DataStore2(IDataStore dataStore)
        {
            _DataStore = dataStore;
        }

        public string SaveData(string data)
        {
            return "DataStore2" + _DataStore.SaveData(data);
        }
    }
}
