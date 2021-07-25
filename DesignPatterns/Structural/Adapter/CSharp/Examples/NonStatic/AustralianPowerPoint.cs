namespace DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic
{
    public class AustralianPowerPoint : IAustralianPowerPoint
    {
        public bool SafetyTurnedOn { get; set; } = true;

        public bool AcceptAustralianPlug(AustralianPowerPlug plug)
        {
            if (SafetyTurnedOn && !plug.Damaged)
            {
                return true;
            }

            return false;
        }
    }
}
