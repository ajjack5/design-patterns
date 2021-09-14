using DesignPatterns.Structural.Proxy.CSharp.Implementation;
using proxy = DesignPatterns.Structural.Proxy.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Proxy
{
    public class DataStoreUnitTests
    {
        [Fact]
        public void SomeOperation_ReturnsTrue()
        {
            // arrange
            IOriginalService originalService = new OriginalService();
             
            // act
            var result = originalService.SomeOperation();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Proxy_CallsSomeOperation_ReturnsTrue()
        {
            // arrange
            IOriginalService originalService = new OriginalService();
            IOriginalService proxy = new proxy.Proxy(originalService);

            // act
            var result = proxy.SomeOperation();

            // assert
            Assert.True(result);
        }
    }
}
