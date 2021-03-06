using DesignPatterns.Creational.Singleton.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.SingletonTests
{
    public class SingletonUnitTests
    {
        [Fact]
        public void GetInstance_InitialisesSingleton()
        {
            // arrange
            // act
            var instance = Singleton.GetInstance();

            // assert
            Assert.NotNull(instance);
        }
    }
}
