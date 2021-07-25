namespace DesignPatterns.Creational.Builder.CSharp.Examples.Normal
{
    public class PasswordResetEmailBuilder
    {
        public IEmail Email { get; private set; } = new Email();

        public void ResetEmail()
        {
            Email = new Email();
        }

        public void FlagEmailForSuspicion()
        {
            Email.Body += "\n <p>Email has been flagged for suspicion</p>";
        }
    }
}
