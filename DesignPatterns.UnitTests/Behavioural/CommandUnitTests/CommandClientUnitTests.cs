using DesignPatterns.Behavioural.Command.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Behavioural.CommandUnitTests
{
    public class CommandClientUnitTests
    {
        [Fact]
        public void Invoker_ShouldInvomeCommand1()
        {
            // arrange
            string instructions = "[These are specific instructions for command 1 only]";

            var service = new BusinessLogicService();
            var invoker = new Invoker();

            Command1 command1 = new Command1(instructions, service);

            // act
            var result = invoker.InvokeCommand(command1);

            // assert
            Assert.Equal($"[These are specific instructions for command 1 only][Executing Command1][SomeSpecificbusinessLogic1]", result);
        }

        [Fact]
        public void Invoker_ShouldInvomeCommand2()
        {
            // arrange
            string instructions = "[These are specific instructions for command 2 only]";

            var service = new BusinessLogicService();
            var invoker = new Invoker();

            Command2 command2 = new Command2(instructions, service);

            // act
            var result = invoker.InvokeCommand(command2);

            // assert
            Assert.Equal($"[These are specific instructions for command 2 only][Executing Command2][SomeSpecificbusinessLogic3]", result);
        }
    }
}
