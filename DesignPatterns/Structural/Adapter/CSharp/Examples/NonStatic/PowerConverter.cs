using System;

namespace DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic
{
    public class PowerConverter
    {
        public AustralianPowerPlug ConvertJapanesePlugIntoAustralianPlug(JapanesePowerPlug japanesePowerPlug)
        {
            var australianPowerPlug = new AustralianPowerPlug();

            australianPowerPlug.DCVoltage = Math.Min(australianPowerPlug.DCVoltage, japanesePowerPlug.DCVoltage);
            australianPowerPlug.Damaged = japanesePowerPlug.Damaged;

            return australianPowerPlug;
        }
    }
}
