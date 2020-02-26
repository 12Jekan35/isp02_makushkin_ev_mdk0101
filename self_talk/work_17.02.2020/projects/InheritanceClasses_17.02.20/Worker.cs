using System;

namespace InheritanceClasses_17._02._20
{
    class Worker: User
    {
        private double salary;
        
        public void SetSalary(double value)
        {
            salary = value;
        }
        public double GetSalary()
        {
            return salary;
        }

        public Worker(int age, string name, double salary)
            :base(age, name)
        {
            SetSalary(salary);
        }
    }
}
