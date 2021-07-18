﻿using System;

namespace DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics
{
    public class AtRiskPlan : IEmployeeManagementPlan
    {
        public DateTimeOffset EndDate { get; set; } = DateTimeOffset.UtcNow;

        private int _Progress = 0;

        public bool IsPlanWorking()
        {
            return _Progress > 20;
        }

        public void UpdateProgress(int updateValue)
        {
            _Progress = updateValue;
        }
    }
}
