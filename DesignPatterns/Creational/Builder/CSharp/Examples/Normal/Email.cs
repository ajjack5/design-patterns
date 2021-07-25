using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.CSharp.Examples.Normal
{
    public class Email : IEmail
    {
        public IList<string> To { get; set; } = new List<string>();
        public IList<string> CC { get; set; } = new List<string>();
        public IList<string> BCC { get; set; } = new List<string>();

        public string From { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
        public object Signature { get; set; }
    }
}
