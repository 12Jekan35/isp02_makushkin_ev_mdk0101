using System;

namespace HierarchyClasses.Hierarchy3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name}";
        }
    }
}
