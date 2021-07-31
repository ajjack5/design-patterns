using DesignPatterns.Structural.Decorator.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Decorator
{
    public class DecoratorUnitTests
    {
        private const string _OriginalString = "[[original implementation]]";
        private const string _DecoratorString = "[[child decorated]]";

        [Fact]
        public void Execute_ReturnsString_WithOriginalComponent()
        {
            // arrange
            var originalComponent = new Component();

            // act
            var result = originalComponent.Execute();

            // assert
            Assert.Equal(_OriginalString, result);
        }

        [Fact]
        public void Execute_ReturnsDecoratedString_WithDecoratingTheOriginalComponent()
        {
            // arrange
            var originalComponent = new Component();
            var decorator = new ChildDecorator(originalComponent);

            // act
            var result = decorator.Execute();

            // assert
            Assert.Equal(_DecoratorString + _OriginalString, result);
        }
    }
}
