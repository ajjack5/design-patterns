namespace DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic
{
    public class JapaneseToAustralianPowerPointAdapter : AustralianPowerPoint
    {
        private readonly PowerConverter _PowerConverter;

        public JapaneseToAustralianPowerPointAdapter(PowerConverter powerConverter)
        {
            _PowerConverter = powerConverter;
        }

        public bool AcceptJapanesePlug(JapanesePowerPlug plug)
        {
            var australianPowerPlug = _PowerConverter.ConvertJapanesePlugIntoAustralianPlug(plug);
            return AcceptAustralianPlug(australianPowerPlug);
        }
    }
}
