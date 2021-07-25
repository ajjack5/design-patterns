using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.CSharp.Examples.Normal
{
    public interface IEmail
    {
        IList<string> To { get; set; }
        IList<string> CC { get; set; }
        IList<string> BCC { get; set; }

        string From { get; set; }

        string Title { get; set; }
        string Body { get; set; }
        object Signature { get; set; }
    }
}
