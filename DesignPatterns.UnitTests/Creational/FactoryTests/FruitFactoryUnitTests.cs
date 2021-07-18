using DesignPatterns.Creational.Factory.CSharp.Examples.Generics;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.FactoryTests
{
    public class FruitFactoryUnitTests
    {
        [Fact]
        public void GetFruit_ReturnsNull_WhenNoExpectedGenericImplementationProvided()
        {
            // arrange
            FruitFactory factory = new FruitFactory();

            // act
            IFruit result = factory.GetFruit<IFruit>();
            
            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GetFruit_ReturnsCorrectFruit_WhenGenericImplementationProvided()
        {
            // arrange
            FruitFactory factory = new FruitFactory();

            // act
            IFruit apple = factory.GetFruit<Apple>();
            IFruit banana = factory.GetFruit<Banana>();
            IFruit tomato = factory.GetFruit<Tomato>();

            // assert
            Assert.NotNull(apple);
            Assert.True(apple.GetType() == typeof(Apple));

            Assert.NotNull(banana);
            Assert.True(banana.GetType() == typeof(Banana));

            Assert.NotNull(tomato);
            Assert.True(tomato.GetType() == typeof(Tomato));
        }

        [Fact]
        public void GetFruit_ReturnsSingleWithCorrectImplementations_WhenSingleRequested()
        {
            // arrange
            FruitFactory factory = new FruitFactory();

            // act
            IFruit banana = factory.GetFruit<Banana>();

            // assert
            Assert.True(banana.Name == "Banana");
            Assert.True(banana.Colour == "Yellow");

            banana.Rot();
            Assert.True(banana.Colour == "Black");
        }
    }
}
