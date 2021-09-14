using Xunit;
using DesignPatterns.Structural.Proxy.CSharp.Examples;

namespace DesignPatterns.UnitTests.Structural.Proxy
{
    public class ProxyUnitTests
    {
        [Fact]
        public void SaveData_ReturnsExpectedString_WhenUsingOriginalService()
        {
            // arrange
            IDataStore dataStore = new DataStore();

            // act
            var result = dataStore.SaveData("data");

            // assert
            Assert.Equal("data has been saved", result);
        }

        [Fact]
        public void SaveData_ReturnsExpectedString_WhenUsingProxy1Service()
        {
            // arrange
            IDataStore dataStore = new DataStore();
            IDataStore proxy1 = new DataStore1(dataStore);

            // act
            var result = proxy1.SaveData("data");

            // assert
            Assert.Equal("DataStore1data has been saved", result);
        }

        [Fact]
        public void SaveData_ReturnsExpectedString_WhenUsingProxy2Service()
        {
            // arrange
            IDataStore dataStore = new DataStore();
            IDataStore proxy2 = new DataStore2(dataStore);

            // act
            var result = proxy2.SaveData("data");

            // assert
            Assert.Equal("DataStore2data has been saved", result);
        }
    }
}
