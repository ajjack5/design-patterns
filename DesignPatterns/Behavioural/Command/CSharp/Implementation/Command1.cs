namespace DesignPatterns.Behavioural.Command.CSharp.Implementation
{
    public class Command1 : ICommand
    {
        private readonly string _Instructions;
        private readonly BusinessLogicService _Service;

        public Command1(string instructions, BusinessLogicService service)
        {
            _Instructions = instructions;
            _Service = service;
        }

        public string Execute()
        {
            var commandString = "[Executing Command1]";
            return $"{_Instructions}{commandString}{_Service.SomeSpecificbusinessLogic1()}";
        }
    }
}
