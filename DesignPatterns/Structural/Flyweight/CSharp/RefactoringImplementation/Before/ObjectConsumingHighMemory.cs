namespace DesignPatterns.Structural.Flyweight.CSharp.RefactoringImplementation.Before
{
    public class ObjectConsumingHighMemory
    {
        public int XPos { get; set; }
        public int YPos { get; set; }

        // not scalable with limited RAM when we initialise a large number of ObjectConsumingHighMemory
        // especially if this data is duplicated in many other objects
        public int[] CommonStaticImageData { get; set; } = new int[10000];
    }
}
