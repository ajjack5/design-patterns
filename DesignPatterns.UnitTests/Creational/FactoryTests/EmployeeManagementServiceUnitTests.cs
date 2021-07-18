using DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.FactoryTests
{
    public class EmployeeManagementServiceUnitTests
    {
        [Fact]
        public void GetEmployeeManagementPlans_ReturnsTheCorrectFactoryPlanImplementation_ForEachEmployee()
        {
            // arrange
            EmployeeManagementService service = new EmployeeManagementService();

            // act
            var result = service.GetEmployeeManagementPlans();

            // assert
            Assert.Equal(3, result.Count);

            Assert.IsAssignableFrom<ProbationaryPlan>(result[0].Item2);
            Assert.IsAssignableFrom<AtRiskPlan>(result[1].Item2);
            Assert.IsAssignableFrom<SuccessPlan>(result[2].Item2);
        }
    }
}
