using System.Timers;

namespace DesignPatterns.Structural.Bridge.CSharp.RefactoringImplementation.After
{
    public class AdvancedRemoteController : RemoteController
    {
        public AdvancedRemoteController(IElectronicDevice electronicDevice) : base(electronicDevice) { }

        public void Mute()
        {
            _ElectronicDevice.Volume = 0;
        }

        public void OpenNetflixChannel()
        {
            _ElectronicDevice.Channel = 42;
        }

        public void Snooze()
        {
            Timer snoozeTimer = new Timer();
            snoozeTimer.Elapsed += new ElapsedEventHandler(OnSnoozedEvent);
            // Real world would have this at 5 or 10 minutes and with asynchronous task scheduling, but this is set to 3 seconds and we dont care about the threads
            snoozeTimer.Interval = 3000;
            snoozeTimer.Enabled = true;
        }

        private void OnSnoozedEvent(object source, ElapsedEventArgs e)
        {
            _ElectronicDevice.PowerOn = false;
        }
    }
}
