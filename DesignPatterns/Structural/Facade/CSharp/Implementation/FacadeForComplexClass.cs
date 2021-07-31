namespace DesignPatterns.Structural.Facade.CSharp.Implementation
{
    public class FacadeForComplexClass
    {
        private readonly IComplexInterface _ComplexClass;

        public FacadeForComplexClass(IComplexInterface complexClass)
        {
            _ComplexClass = complexClass;
        }

        // by using this object, we don't need to worry about all the internals
        // or the massive amounts of methods on the interface, just use this 1 implementation
        public bool Send(string message)
        {
            bool validatedMessage = _ComplexClass.ValidateMessage(message);
            if (validatedMessage)
            {
                bool isQueued = _ComplexClass.IsMessageQueuedToSend(message);
                if (!isQueued)
                {
                    return _ComplexClass.SendMessage(message);
                }
            }

            return false;
        }
    }
}
