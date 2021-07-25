namespace DesignPatterns.Creational.Builder.CSharp.Implementation
{
    public interface IBuilder<T> where T : class
    {
        T GetInstance();

        void Reset();
        void SetSpecific(int number);
        void SetOtherSpecific(int number);
    }
}
