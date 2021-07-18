using System;

namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public class ProbationaryPlan : IEmployeeManagementPlan
    {
        public DateTimeOffset EndDate { get; set; } = DateTimeOffset.UtcNow;

        private int _Progress = 0;

        public bool IsPlanWorking()
        {
            return _Progress > 50;
        }

        public void UpdateProgress(int updateValue)
        {
            _Progress = updateValue;
        }
    }
}
