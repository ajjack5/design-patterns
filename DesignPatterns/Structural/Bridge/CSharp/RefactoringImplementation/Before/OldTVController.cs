namespace DesignPatterns.Structural.Bridge.CSharp.RefactoringImplementation.Before
{
    public class OldTVController
    {
        public void PowerOn(OldTV radio)
        {
            radio.PowerOn = true;
        }

        public void PowerOff(OldTV radio)
        {
            radio.PowerOn = false;
        }

        public void Enable(OldTV radio)
        {
            radio.Enabled = true;
        }

        public void Disable(OldTV radio)
        {
            radio.Enabled = false;
        }

        public int GetVolume(OldTV radio)
        {
            return radio.Volume;
        }

        public void SetVolume(OldTV radio, int volume)
        {
            radio.Volume = volume;
        }

        public int GetChannel(OldTV radio)
        {
            return radio.Channel;
        }

        public void SetChannel(OldTV radio, int channel)
        {
            radio.Channel = channel;
        }
    }
}
