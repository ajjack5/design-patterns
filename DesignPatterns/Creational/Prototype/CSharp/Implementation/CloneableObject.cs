namespace DesignPatterns.Creational.Prototype.CSharp.Implementation
{
    public class CloneableObject : Prototype
    {
        public int SpecificObjectData { get; set; }

        public CloneableObject(): base() { }

        private CloneableObject(CloneableObject originalObject) : base(originalObject)
        {
            SpecificObjectData = originalObject.SpecificObjectData;
        }

        public CloneableObject Clone()
        {
            return new CloneableObject(this);
        }
    }
}
