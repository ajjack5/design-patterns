using DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.FactoryTests
{
    public class EmployeeManagementFactoryUnitTests
    {
        [Fact]
        public void GetPlan_ReturnsNull_WhenNoFactoryImplementationProvided()
        {
            // arrange
            IEmployeeManagementFactory factory = new EmployeeManagementFactory();

            // act
            var result = factory.GetPlan();

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void GetPlan_ReturnsCorrectPlan_WhenExplicitFactoryImplementationProvided()
        {
            // arrange
            IEmployeeManagementFactory factory1 = new ProbationaryManagement();
            IEmployeeManagementFactory factory2 = new AtRiskManagement();
            IEmployeeManagementFactory factory3 = new SuccessManagement();
            
            // act
            var result1 = factory1.GetPlan();
            var result2 = factory2.GetPlan();
            var result3 = factory3.GetPlan();
            
            // assert
            Assert.NotNull(result1);
            Assert.NotNull(result2);
            Assert.NotNull(result3);
        }
    }
}
