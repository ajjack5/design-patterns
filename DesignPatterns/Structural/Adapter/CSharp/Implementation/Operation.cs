namespace DesignPatterns.Structural.Adapter.CSharp.Implementation
{
    public class Operation : IOperation
    {
        public int Invoke(string data)
        {
            return data?.Length ?? 0;
        }
    }
}
