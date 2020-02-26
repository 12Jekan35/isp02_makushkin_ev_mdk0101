using System;

namespace Classes
{
    class Employee
    {
        private double workStage;

        public string Name { get; set; }

        public string Profession { get; set; }

        public double WorkStage 
        {
            get => workStage;

            set 
            {
                if (value < 0)
                    throw (new Exception("Enter invalid value"));
                else 
                    workStage = value;
            }
        }

        public override string ToString()
        {
            string info = $"Work Stage: {workStage} " +
                          $"Name: {Name} " +
                          $"Profession: {Profession}";
            return info;
        }

        public Employee(string name, string profession, double workStage = 0)
        {
            WorkStage = workStage;
            Name = name;
            Profession = profession;
        }
    }
}
