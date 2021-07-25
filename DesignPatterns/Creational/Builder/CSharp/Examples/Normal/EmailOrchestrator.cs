using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.CSharp.Examples.Normal
{
    public class EmailOrchestrator : IEmailOrchestrator
    {
        private bool _Suspicious = false;

        public IEmail CreatePasswordResetEmail(string to)
        {
            var builder = new PasswordResetEmailBuilder();

            builder.ResetEmail();

            builder.Email.To = new List<string> { to };
            builder.Email.From = "ourservice@ourservice";
            builder.Email.Title = $"Password reset for {to}";
            builder.Email.Body = "password reset link goes here";

            if (_Suspicious)
            {
                builder.FlagEmailForSuspicion();
            }

            return builder.Email;
        }

        public IEmail CreateSuspiciousActivityEmail(string to)
        {
            var builder = new SuspiciousActivityEmailBuilder();

            builder.ResetEmail();

            builder.Email.To = new List<string> { to };
            builder.Email.From = "ourservice@ourservice";
            builder.Email.Title = $"Suspicious Activity Detected";
            builder.Email.Body = "additional info here";

            builder.FlagEmailForSuspicion();

            return builder.Email;
        }

        public IEmail CreateWeeklyNewsletterEmail(string to)
        {
            var builder = new WeeklyNewsletterEmailBuilder();

            builder.Email.To = new List<string> { to };
            builder.Email.CC = new List<string> { "other", "emails", "go", "here" };
            builder.Email.BCC = new List<string> { "hidden", "emails", "go", "here" };

            builder.Email.From = "ourservice@ourservice";
            builder.Email.Title = $"Weekly Newsletter";

            builder.AttachWeeklyCatalogue();

            builder.Email.Signature = new object();

            return builder.Email;
        }
    }
}
