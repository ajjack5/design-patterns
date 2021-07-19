using System;

namespace DesignPatterns.Creational.Prototype.CSharp.Examples
{
    public class Coronavirus : Virus, IVirus
    {
        public Coronavirus() : base()
        {
            GeneticMaterial = Guid.NewGuid().ToString();
        }

        private Coronavirus(Coronavirus originalVirus) : base(originalVirus)
        {
            GeneticMaterial = originalVirus.GeneticMaterial;
        }

        public IVirus InfectHostCell()
        {
            var clone = new Coronavirus(this);
            clone.Mutate();

            return clone;
        }

        public void Mutate()
        {
            GeneticMaterial = Guid.NewGuid().ToString();
        }
    }
}
