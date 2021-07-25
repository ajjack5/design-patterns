namespace DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic
{
    public interface IPowerPlug
    {
        int NumMetalProngs { get; set; }
        int DCVoltage { get; set; }
        bool Damaged { get; set; }
    }
}
