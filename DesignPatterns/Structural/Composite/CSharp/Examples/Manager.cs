using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite.CSharp.Examples
{
    public class Manager : IEmployee
    {
        public IList<IEmployee> Employees = new List<IEmployee>();

        public string Name { get; set; }

        public bool CompleteWorkTask()
        {
            if (Employees == null || Employees.Count == 0) {
                return false;
            }

            return Employees.All(x => x.CompleteWorkTask());
        }
    }
}
