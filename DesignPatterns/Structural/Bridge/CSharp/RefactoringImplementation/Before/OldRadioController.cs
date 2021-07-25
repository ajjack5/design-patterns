namespace DesignPatterns.Structural.Bridge.CSharp.RefactoringImplementation.Before
{
    public class OldRadioController
    {
        public void PowerOn(OldRadio radio)
        {
            radio.PowerOn = true;
        }

        public void PowerOff(OldRadio radio)
        {
            radio.PowerOn = false;
        }

        public void Enable(OldRadio radio)
        {
            radio.Enabled = true;
        }

        public void Disable(OldRadio radio)
        {
            radio.Enabled = false;
        }

        public int GetVolume(OldRadio radio)
        {
            return radio.Volume;
        }

        public void SetVolume(OldRadio radio, int volume)
        {
            radio.Volume = volume;
        }

        public int GetChannel(OldRadio radio)
        {
            return radio.Channel;
        }

        public void SetChannel(OldRadio radio, int channel)
        {
            radio.Channel = channel;
        }
    }
}
