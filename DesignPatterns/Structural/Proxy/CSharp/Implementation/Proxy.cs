namespace DesignPatterns.Structural.Proxy.CSharp.Implementation
{
    public class Proxy : IOriginalService
    {
        private readonly IOriginalService _OriginalService;
        private const bool _ToggleProxy = true;

        public Proxy(IOriginalService OriginalService)
        {
            _OriginalService = OriginalService;
        }

        // same reference to interface function as original
        public bool SomeOperation()
        {
            if (_ToggleProxy)
            {
                return _OriginalService.SomeOperation();
            }
        }
    }
}
