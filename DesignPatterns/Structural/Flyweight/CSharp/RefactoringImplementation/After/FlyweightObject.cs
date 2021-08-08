namespace DesignPatterns.Structural.Flyweight.CSharp.RefactoringImplementation.After
{
    public class FlyweightObject
    {
        public int XPos { get; set; }
        public int YPos { get; set; }

        public int[] CommonStaticImageData { get => _CommonStaticImage.ImageData; }

        // immutable common flyweight data
        private readonly CommonStaticImage _CommonStaticImage;
        
        // explicit ref
        public FlyweightObject(ref CommonStaticImage commonStaticImage)
        {
            _CommonStaticImage = commonStaticImage;
        }
    }
}
