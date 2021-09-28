namespace DesignPatterns.Behavioural.Command.CSharp.Implementation
{
    public class Invoker
    {
        public string InvokeCommand(ICommand command)
        {
            return command.Execute();
        }
    }
}
