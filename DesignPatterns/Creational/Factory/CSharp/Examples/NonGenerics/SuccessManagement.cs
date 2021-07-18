namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public class SuccessManagement : EmployeeManagementFactory
    {
        public override IEmployeeManagementPlan GetPlan()
        {
            return new SuccessPlan();
        }
    }
}
