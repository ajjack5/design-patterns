namespace DesignPatterns.Behavioural.ChainOfResponsibility.CSharp.Implementation
{
    public class BeforeHandler : BaseHandler
    {
        public BeforeHandler(IHandler nextHandler) : base()
        {
            Next = nextHandler;
        }

        public override int Handle(bool flag)
        {
            int result = 42;
            int nextResult = 0;

            if (Next != null && flag == true)
            {
                nextResult = Next.Handle(flag);
            }
            else
            {
                base.Handle(flag);
            }

            return result + nextResult;
        }
    }
}
