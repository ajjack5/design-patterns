namespace DesignPatterns.Structural.Flyweight.CSharp.RefactoringImplementation.After
{
    public class FlyweightObject
    {
        public int XPos { get; set; }
        public int YPos { get; set; }

        public int[] CommonStaticImageData { get => CommonStaticImage.ImageData; }

        // immutable common flyweight data
        private readonly CommonStaticImage CommonStaticImage;
        
        // explicit ref
        public FlyweightObject(ref CommonStaticImage commonStaticImage)
        {
            CommonStaticImage = commonStaticImage;
        }
    }
}
