using DesignPatterns.Structural.Bridge.CSharp.RefactoringImplementation.After;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Bridge
{
    public class BridgeUnitTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void RemoteController_InitialisesWithDevices_UponInitialisation(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            RemoteController remote = new RemoteController(device);

            // act
            // assert
            Assert.NotNull(remote); // logically this should never fail...

            Assert.False(device.PowerOn);
            Assert.False(device.Enabled);
            Assert.Equal(0, device.Volume);
            Assert.Equal(0, device.Channel);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void TogglePower_TogglesPower_WithRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            RemoteController remote = new RemoteController(device);

            // act
            remote.TogglePower();

            // assert
            Assert.True(device.PowerOn);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void VolumeUp_TurnsTheVolumeUpBy1Increment_WithRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            RemoteController remote = new RemoteController(device);
            var volume = device.Volume;

            // act
            remote.VolumeUp();

            // assert
            Assert.Equal(device.Volume, volume + 1);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void VolumeUp_TurnsTheVolumeDownBy1Increment_WithRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            RemoteController remote = new RemoteController(device);
            var volume = device.Volume;

            // act
            remote.VolumeDown();

            // assert
            Assert.Equal(device.Volume, volume - 1);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChannelUp_TurnsTheChannelUpBy1Increment_WithRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            RemoteController remote = new RemoteController(device);
            var channel = device.Channel;

            // act
            remote.ChannelUp();

            // assert
            Assert.Equal(device.Channel, channel + 1);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChannelDown_TurnsTheChannelDownBy1Increment_WithRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            RemoteController remote = new RemoteController(device);
            var channel = device.Channel;

            // act
            remote.ChannelDown();

            // assert
            Assert.Equal(device.Channel, channel - 1);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Mute_TurnsTheVolumeTo0_WithAdvancedRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            AdvancedRemoteController remote = new AdvancedRemoteController(device);
            
            device.Volume = 100;

            // act
            remote.Mute();

            // assert
            Assert.Equal(0, device.Volume);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void OpenNetflixChannel_OpensTheSpecificChannel_WithAdvancedRemoteController(bool useRadio)
        {
            // arrange
            IElectronicDevice device = useRadio ? new NewRadio() : new NewTV();
            AdvancedRemoteController remote = new AdvancedRemoteController(device);

            device.Channel = 4;

            // act
            remote.OpenNetflixChannel();

            // assert
            Assert.Equal(42, device.Channel);
        }

        // and so on ...
    }
}

