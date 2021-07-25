using DesignPatterns.Creational.AbstractFactory.CSharp.DependencyInjection;
using DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.AbstractFactoryUnitTests
{
    public class AbstractFactoryRootCompositionUnitTests
    {
        [Fact]
        public void ConfigureServices_UsesReflectionToGetGenericAbstractFactory_WhenInjectionTypeSpecified()
        {
            // arrange
            var serviceProvider = AbstractFactoryRootComposition.ConfigureServices();

            // act
            IFurnitureFactory<OldFurnitureFactory> result = serviceProvider.GetRequiredService<IFurnitureFactory<OldFurnitureFactory>>();

            // assert
            Assert.NotNull(result);
            Assert.IsType<OldChair>(result.CreateChair());
        }
    }
}
