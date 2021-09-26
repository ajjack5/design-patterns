using DesignPatterns.Behavioural.ChainOfResponsibility.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Behavioural.ChainOfResponsibilityUnitTests
{
    public class HandlerUnitTests
    {
        [Theory]
        [InlineData(true, 45)]
        [InlineData(false, 42)]

        public void Handle_ShouldHandleRequest_WhenNextHandlerExists(bool flag, int expectedHandleResponse)
        {
            // arrange
            AfterHandler afterHandler = new AfterHandler(null);
            BeforeHandler beforeHandler = new BeforeHandler(afterHandler);

            // act
            var result = beforeHandler.Handle(flag);

            // assert
            Assert.Equal(expectedHandleResponse, result);
        }

        [Theory]
        [InlineData(true, 42)]
        [InlineData(false, 42)]
        public void Handle_ShouldNotHandleRequest_WhenNextHandlerIsNull(bool flag, int expectedHandleResponse)
        {
            // arrange
            BeforeHandler beforeHandler = new BeforeHandler(null);

            // act
            var result = beforeHandler.Handle(flag);

            // assert
            Assert.Equal(expectedHandleResponse, result);
        }
    }
}
