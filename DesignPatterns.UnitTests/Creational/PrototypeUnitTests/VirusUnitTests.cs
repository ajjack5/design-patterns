using DesignPatterns.Creational.Prototype.CSharp.Examples;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.PrototypeUnitTests
{
    public class VirusUnitTests
    {
        [Fact]
        public void InfectHostCell_InitialisesANewCopyOfThePrototypeObject_WhenInvoked()
        {
            // arrange
            var virus = new Coronavirus();

            // act
            var result = virus.InfectHostCell();

            // assert
            Assert.NotNull(result);
            
            var virusRef = virus.GetHashCode();
            var clonedVirusRef = result.GetHashCode();

            Assert.NotEqual(virusRef, clonedVirusRef);
        }

        [Fact]
        public void InfectHostCell_ClonesAndMutatesOriginalVirus_WhenInvoked()
        {
            // arrange
            var virus = new Coronavirus();
            var originalGeneticMaterial = virus.GeneticMaterial;

            // act
            var result = virus.InfectHostCell();
            var clonedGeneticMaterial = (result as Coronavirus).GeneticMaterial;

            // assert
            Assert.NotEqual(originalGeneticMaterial, clonedGeneticMaterial);
        }

        [Fact]
        public void Mutate_ChangesGeneticMaterial_WhenInvoked()
        {
            // arrange
            var virus = new Influenza();
            var originalGeneticMaterial = virus.GeneticMaterial;

            // act
            virus.Mutate();
            var newGeneticMaterial = virus.GeneticMaterial;

            // assert
            Assert.NotEqual(originalGeneticMaterial, newGeneticMaterial);
        }
    }
}
