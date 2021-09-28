using DesignPatterns.Behavioural.Command.CSharp.Examples;
using System.Linq;
using Xunit;

namespace DesignPatterns.UnitTests.Behavioural.CommandUnitTests
{
    public class UpdateUserCommandUnitTests
    {

        [Fact]
        public void UpdateUser_UpdatesAndReturnsUser_WhenIdExists() {
            // arrange
            UserContext userContext = new UserContext();
            IUpdateUserCommand updateUserCommand = new UpdateUserCommand(userContext);

            var userToUpdate = userContext.Users?.ToArray()[0];
            userToUpdate.Name = "qwertyuiop";

            // act
            var result = updateUserCommand.UpdateUser(userToUpdate);

            // assert
            Assert.Equal("qwertyuiop", result.Name);
        }
    }
}
