namespace DesignPatterns.Creational.Builder.CSharp.Examples.Normal
{
    public class WeeklyNewsletterEmailBuilder
    {
        public IEmail Email { get; private set; } = new Email();

        public void ResetEmail()
        {
            Email = new Email();
        }

        public void AttachWeeklyCatalogue()
        {
            // function to attach attachment to email
        }
    }
}
