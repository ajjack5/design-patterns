namespace DesignPatterns.Behavioural.Command.CSharp.Implementation
{
    public class Command2 : ICommand
    {
        private readonly string _Instructions;
        private readonly BusinessLogicService _Service;

        public Command2(string instructions, BusinessLogicService service)
        {
            _Instructions = instructions;
            _Service = service;
        }

        public string Execute()
        {
            var commandString = "[Executing Command2]";
            return $"{_Instructions}{commandString}{_Service.SomeSpecificbusinessLogic3()}";
        }
    }
}
