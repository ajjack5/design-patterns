namespace DesignPatterns.Behavioural.ChainOfResponsibility.CSharp.Implementation
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler Next { get; set; }

        public virtual int Handle(bool flag)
        {
            if (Next != null)
            {
                return Next.Handle(flag);
            }

            return 0;
        }
    }
}
