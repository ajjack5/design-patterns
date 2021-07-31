using DesignPatterns.Structural.Facade.CSharp.Implementation;
using Moq;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Facade
{
    public class FacadeUnitTests
    {
        private readonly Mock<IComplexInterface> _ComplexInterfaceMock = new Mock<IComplexInterface>();
        private readonly FacadeForComplexClass _Sut;

        public FacadeUnitTests()
        {
            _Sut = new FacadeForComplexClass(_ComplexInterfaceMock.Object);
        }

        [Fact]
        public void Send_SendsMessage_WithoutNeedingToWorryAboutInternals()
        {
            // arrange
            _ComplexInterfaceMock.Setup(x => x.ValidateMessage(It.IsAny<string>())).Returns(true).Verifiable();
            _ComplexInterfaceMock.Setup(x => x.IsMessageQueuedToSend(It.IsAny<string>())).Returns(false).Verifiable();
            _ComplexInterfaceMock.Setup(x => x.SendMessage(It.IsAny<string>())).Returns(false).Verifiable();

            // act
            _Sut.Send("Some Random Message");

            // assert
            _ComplexInterfaceMock.Verify();
        }
    }
}
