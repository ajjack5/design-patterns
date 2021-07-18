using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public enum EmployeeStatus
    {
        Probationary = 0,
        AtRisk = 1,
        Success = 2
    }

    public class EmployeeManagementService
    {
        private IList<Tuple<string, EmployeeStatus>> _Employees = new List<Tuple<string, EmployeeStatus>>();

        public EmployeeManagementService()
        {
            SeedStaticData();
        }

        // Example of using the factory
        public IList<Tuple<string, IEmployeeManagementPlan>> GetEmployeeManagementPlans()
        {
            IList<Tuple<string, IEmployeeManagementPlan>> EmployeeManagementPlans = new List<Tuple<string, IEmployeeManagementPlan>>();

            foreach(var employee in _Employees)
            {
                IEmployeeManagementFactory factory;

                switch (employee.Item2)
                {
                    case EmployeeStatus.Probationary:
                        factory = new ProbationaryManagement();
                        break;

                    case EmployeeStatus.AtRisk:
                        factory = new AtRiskManagement();
                        break;

                    case EmployeeStatus.Success:
                        factory = new SuccessManagement();
                        break;

                    default:
                        factory = new SuccessManagement();
                        break;
                }

                IEmployeeManagementPlan plan = factory.GetPlan();

                EmployeeManagementPlans.Add(new Tuple<string, IEmployeeManagementPlan>(employee.Item1, plan));
            }

            return EmployeeManagementPlans;
        }

        private void SeedStaticData()
        {
            _Employees.Add(new Tuple<string, EmployeeStatus>("Person1", EmployeeStatus.Probationary));
            _Employees.Add(new Tuple<string, EmployeeStatus>("Person2", EmployeeStatus.AtRisk));
            _Employees.Add(new Tuple<string, EmployeeStatus>("Person3", EmployeeStatus.Success));
        }
    }
}
