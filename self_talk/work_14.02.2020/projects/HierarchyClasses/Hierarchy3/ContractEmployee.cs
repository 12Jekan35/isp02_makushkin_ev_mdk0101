using System;

namespace HierarchyClasses.Hierarchy3
{
    class ContractEmployee: Employee
    {
        public double PayPerHour { get; set; }
        public string ContractPeriod { get; set; }

        public ContractEmployee(int id, string name, double payPerHour, string contractPeriod)
            :base(id, name)
        {
            PayPerHour = payPerHour;
            ContractPeriod = contractPeriod;
        }

        public override string ToString()
        {
            return base.ToString() + $" Pay per hour: {PayPerHour} Contract period: {ContractPeriod}";
        }
    }
}
