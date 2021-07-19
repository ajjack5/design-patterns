using System;

namespace DesignPatterns.Creational.Prototype.CSharp.Examples
{
    public class Influenza : Virus, IVirus
    {
        public Influenza() : base()
        {
            GeneticMaterial = Guid.NewGuid().ToString();
        }

        private Influenza(Influenza originalVirus) : base(originalVirus)
        {
            GeneticMaterial = originalVirus.GeneticMaterial;
        }

        public IVirus InfectHostCell()
        {
            var clone = new Influenza(this);
            clone.Mutate();

            return clone;
        }

        public void Mutate()
        {
            GeneticMaterial = GeneticMaterial + Guid.NewGuid().ToString();
        }
    }
}
