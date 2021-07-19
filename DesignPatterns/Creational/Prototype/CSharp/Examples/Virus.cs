namespace DesignPatterns.Creational.Prototype.CSharp.Examples
{
    public abstract class Virus
    {
        public string GeneticMaterial { get; set; }

        protected Virus() { }

        protected Virus(Virus originalVirus)
        {
            GeneticMaterial = originalVirus.GeneticMaterial;
        }
    }
}
