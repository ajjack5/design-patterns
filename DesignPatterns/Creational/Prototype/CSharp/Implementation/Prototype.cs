namespace DesignPatterns.Creational.Prototype.CSharp.Implementation
{
    public abstract class Prototype
    {
        public int SharedData { get; set; }
        public int OtherSharedData { get; set; }

        protected Prototype() { }

        protected Prototype(Prototype originalObject)
        {
            SharedData = originalObject.SharedData;
            OtherSharedData = originalObject.OtherSharedData;
        }
    }
}
