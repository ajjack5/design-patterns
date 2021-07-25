namespace DesignPatterns.Creational.Builder.CSharp.Examples.Normal
{
    public interface IEmailOrchestrator
    {
        public IEmail CreatePasswordResetEmail(string to);
        public IEmail CreateSuspiciousActivityEmail(string to);
        public IEmail CreateWeeklyNewsletterEmail(string to);
    }
}
