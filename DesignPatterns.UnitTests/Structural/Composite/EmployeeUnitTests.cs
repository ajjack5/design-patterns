using DesignPatterns.Structural.Composite.CSharp.Examples;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Composite
{
    public class EmployeeUnitTests
    {
        [Fact]
        public void CompleteWorkTask_ReturnsTrue_WhenOnlyAnEmployee()
        {
            // arrange
            IEmployee employee = new Employee();

            // act
            var result = employee.CompleteWorkTask();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void CompleteWorkTask_ReturnsFalse_WhenOnlyAManager()
        {
            // arrange
            IEmployee manager = new Manager();

            // act
            var result = manager.CompleteWorkTask();

            // assert
            Assert.False(result);
        }

        [Fact]
        public void CompleteWorkTask_ReturnsTrue_WhenManagerDelegatesWork()
        {
            // arrange
            var CEO = new Manager { Name = "The Strategist" };
            var HeadOfDepartment = new Manager { Name = "The Planner" };
            var TeamLead = new Manager { Name = "The Executer" };

            var JuniorEngineer = new Employee { Name = "The Learner" };
            var MidEngineer = new Employee { Name = "The Coder" };
            var SeniorEngineer = new Employee { Name = "The Master Coder" };

            CEO.Employees.Add(HeadOfDepartment);
            HeadOfDepartment.Employees.Add(TeamLead);

            TeamLead.Employees.Add(JuniorEngineer);
            TeamLead.Employees.Add(MidEngineer);
            TeamLead.Employees.Add(SeniorEngineer);

            // act
            var result = CEO.CompleteWorkTask();

            // assert
            Assert.True(result);
        }
    }
}
