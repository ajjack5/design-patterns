namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public class ProbationaryManagement : EmployeeManagementFactory
    {
        public override IEmployeeManagementPlan GetPlan()
        {
            return new ProbationaryPlan();
        }
    }
}
