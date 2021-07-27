namespace DesignPatterns.Structural.Composite.CSharp.Examples
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }

        public bool CompleteWorkTask()
        {
            // do
            return true;
        }
    }
}
