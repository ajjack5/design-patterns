using DesignPatterns.Behavioural.Command.CSharp.Examples;
using Xunit;

namespace DesignPatterns.UnitTests.Behavioural.CommandUnitTests
{
    public class GetUserCommandUnitTests
    {

        [Fact]
        public void GetUser_ReturnsUser_WhenIdExists() {
            // arrange
            UserContext userContext = new UserContext();
            IGetUserCommand getUserCommand = new GetUserCommand(userContext);

            // act
            var result = getUserCommand.GetUser(1);

            // assert
            Assert.Equal("Person 1", result.Name);
        }

        [Fact]
        public void GetUser_ReturnsUser_WhenNameExists()
        {
            // arrange
            UserContext userContext = new UserContext();
            IGetUserCommand getUserCommand = new GetUserCommand(userContext);

            // act
            var result = getUserCommand.GetUser("Person 1");

            // assert
            Assert.Equal(1, result.ID);
        }
    }
}
