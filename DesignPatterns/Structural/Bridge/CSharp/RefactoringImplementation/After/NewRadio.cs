namespace DesignPatterns.Structural.Bridge.CSharp.RefactoringImplementation.After
{
    public class NewRadio : IElectronicDevice
    {
        public bool PowerOn { get; set; }
        public bool Enabled { get; set; }
        public int Volume { get; set; }
        public int Channel { get; set; }
        public int Frequency { get; set; }
    }
}
