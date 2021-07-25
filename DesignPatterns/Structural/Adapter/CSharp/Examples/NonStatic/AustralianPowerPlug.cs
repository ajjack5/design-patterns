namespace DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic
{
    public class AustralianPowerPlug : IPowerPlug
    {
        public int NumMetalProngs { get; set; } = 3;
        public int DCVoltage { get; set; } = 240;
        public bool Damaged { get; set; }
    }
}
