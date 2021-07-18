using System;

namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public interface IEmployeeManagementPlan
    {
        DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Updates the Progress of the employee.
        /// </summary>
        /// <param name="updateValue">
        /// Value between 0 and 100 representing the employee competence at their role
        /// </param>
        void UpdateProgress(int updateValue);
        bool IsPlanWorking();
    }
}
