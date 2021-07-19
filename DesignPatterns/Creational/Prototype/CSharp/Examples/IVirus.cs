namespace DesignPatterns.Creational.Prototype.CSharp.Examples
{
    public interface IVirus
    {
        IVirus InfectHostCell();
        void Mutate();
    }
}
