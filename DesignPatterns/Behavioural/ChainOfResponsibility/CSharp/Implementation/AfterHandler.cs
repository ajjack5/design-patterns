namespace DesignPatterns.Behavioural.ChainOfResponsibility.CSharp.Implementation
{
    public class AfterHandler : BaseHandler
    {
        public AfterHandler(IHandler nextHandler) : base()
        {
            Next = nextHandler;
        }

        public override int Handle(bool flag)
        {
            int result = 3;
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
