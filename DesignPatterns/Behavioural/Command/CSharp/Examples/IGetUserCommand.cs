namespace DesignPatterns.Behavioural.Command.CSharp.Examples
{
    public interface IGetUserCommand
    {
        User GetUser(int id);

        User GetUser(string name);

        User GetUser(int id, string name);
    }
}
