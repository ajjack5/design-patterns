namespace DesignPatterns.Structural.Facade.CSharp.Implementation
{
    public interface IComplexInterface
    {
        bool SendMessage(string message);
        bool SendMessage(string message, int number);
        bool SendMessageAfterMinutes(string message, int minutes);
        bool SendMessageAfterSeconds(string message, int seconds);

        bool ValidateMessage(string message);
        bool IsMessageQueuedToSend(string message);
    }
}
