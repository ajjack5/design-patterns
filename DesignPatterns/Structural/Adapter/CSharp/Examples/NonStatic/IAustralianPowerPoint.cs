namespace DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic
{
    public interface IAustralianPowerPoint
    {
        bool AcceptAustralianPlug(AustralianPowerPlug plug);
        bool SafetyTurnedOn { get; set; }
    }
}
