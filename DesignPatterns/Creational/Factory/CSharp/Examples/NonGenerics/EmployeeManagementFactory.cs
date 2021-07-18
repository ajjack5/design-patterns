namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public class EmployeeManagementFactory : IEmployeeManagementFactory
    {
        public virtual IEmployeeManagementPlan GetPlan()
        {
            return null;
        }
    }
}
