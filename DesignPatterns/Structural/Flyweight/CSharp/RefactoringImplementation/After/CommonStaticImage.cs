namespace DesignPatterns.Structural.Flyweight.CSharp.RefactoringImplementation.After
{
    public sealed class CommonStaticImage
    {
        public readonly int[] ImageData;
        // mark as immutable

        public CommonStaticImage()
        {
            ImageData = new int[10000];
            // sets the static image data once
        }
    }
}
