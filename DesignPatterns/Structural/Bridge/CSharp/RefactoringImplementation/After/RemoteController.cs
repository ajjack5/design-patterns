namespace DesignPatterns.Structural.Bridge.CSharp.RefactoringImplementation.After
{
    public class RemoteController
    {
        protected readonly IElectronicDevice _ElectronicDevice;

        public RemoteController(IElectronicDevice electronicDevice)
        {
            _ElectronicDevice = electronicDevice;
        }

        public void TogglePower()
        {
            _ElectronicDevice.PowerOn = !_ElectronicDevice.PowerOn;
        }

        public void VolumeUp()
        {
            _ElectronicDevice.Volume++;
        }

        public void VolumeDown()
        {
            _ElectronicDevice.Volume--;
        }

        public void ChannelUp()
        {
            _ElectronicDevice.Channel++;
        }

        public void ChannelDown()
        {
            _ElectronicDevice.Channel--;
        }
    }
}
