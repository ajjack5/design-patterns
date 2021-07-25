using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.CSharp.Examples.Static
{
    public class StandardEmail
    {
        public IList<string> To { get; set; } = new List<string>();
        public string From { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
    }
}
