using DesignPatterns.Creational.Singleton.CSharp.Examples;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.SingletonTests
{
    public class UniverseUnitTests
    {
        [Fact]
        public void BigBang_ShouldInitialiseUniverse()
        {
            // arrange
            // act
            var univserse = Universe.BigBang();

            // assert
            Assert.NotNull(univserse);
        }

        [Fact]
        public void YearsSinceBigBang_ShouldDefaultUniverseAgeToZero()
        {
            // arrange
            var univserse = Universe.BigBang();

            // act
            var result = univserse.YearsSinceBigBang;

            // assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void TravelToTheEndOfTime_ShouldSetUniverseAgeToMaxLongValue()
        {
            // arrange
            var univserse = Universe.BigBang();

            // act
            univserse.TravelToTheEndOfTime();

            // assert
            Assert.Equal(long.MaxValue, univserse.YearsSinceBigBang);
        }

        [Fact]
        public void TravelToTheBeginningOfTime_ShouldSetUniverseAgeToZero()
        {
            // arrange
            var univserse = Universe.BigBang();
            univserse.YearsSinceBigBang = 42;

            // act
            univserse.TravelToTheBeginningOfTime();

            // assert
            Assert.Equal(0, univserse.YearsSinceBigBang);
        }
    }
}
