using DesignPatterns.Creational.AbstractFactory.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.AbstractFactoryUnitTests
{
    public enum FactoryType
    {
        Factory1 = 0,
        Factory2 = 1
    }

    public class AbstractFactoryUnitTests
    {
        [Theory]
        [InlineData(FactoryType.Factory1)]
        [InlineData(FactoryType.Factory2)]
        public void CreateProductA_ReturnsProductA_WithDifferentFactoryImplementationsDependingOnTheType(FactoryType factoryType)
        {
            // arrange
            IAbstractFactory factory = (factoryType == FactoryType.Factory1) ? new Factory1() : new Factory2();

            // act
            var result = factory.CreateProductA();

            // assert
            Assert.IsAssignableFrom<ProductA>(result);

            if (factoryType == FactoryType.Factory1)
            {
                Assert.Equal("unique Factory1ProductA property", result.Property);
            }

            if (factoryType == FactoryType.Factory2)
            {
                Assert.Equal("unique Factory2ProductA property", result.Property);
            }
        }

        [Theory]
        [InlineData(FactoryType.Factory1)]
        [InlineData(FactoryType.Factory2)]
        public void CreateProductB_ReturnsProductB_WithDifferentFactoryImplementationsDependingOnTheType(FactoryType factoryType)
        {
            // arrange
            IAbstractFactory factory = (factoryType == FactoryType.Factory1) ? new Factory1() : new Factory2();

            // act
            var result = factory.CreateProductB();

            // assert
            Assert.IsAssignableFrom<ProductB>(result);
            
            if (factoryType == FactoryType.Factory1)
            {
                Assert.Equal("unique Factory1ProductB property", result.Property);
            }

            if (factoryType == FactoryType.Factory2)
            {
                Assert.Equal("unique Factory2ProductB property", result.Property);
            }
        }
    }
}
