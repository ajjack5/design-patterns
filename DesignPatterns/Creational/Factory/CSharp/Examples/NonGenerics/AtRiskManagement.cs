namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public class AtRiskManagement : EmployeeManagementFactory
    {
        public override IEmployeeManagementPlan GetPlan()
        {
            return new AtRiskPlan();
        }
    }
}
