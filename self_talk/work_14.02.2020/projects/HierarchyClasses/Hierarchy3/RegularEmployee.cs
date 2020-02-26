using System;

namespace HierarchyClasses.Hierarchy3
{
    class RegularEmployee: Employee
    {
        public double Salary { get; set; }
        public int Bonus { get; set; }

        public RegularEmployee(int id, string name, double salary, int bonus)
            :base(id, name)
        {
            Salary = salary;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {Salary} Bonus: {Bonus}";
        }
    }
}
