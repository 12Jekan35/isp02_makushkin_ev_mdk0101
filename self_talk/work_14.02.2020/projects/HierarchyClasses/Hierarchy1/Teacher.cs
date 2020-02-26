using System;

namespace HierarchyClasses.Hierarchy1
{
    class Teacher : Person
    {
        private string[] disciplines;

        public Teacher(int age, string name, params string[] disciplines)
            : base (age, name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(string discipline)
        {
            Array.Resize(ref disciplines, disciplines.Length + 1);

            disciplines[disciplines.Length - 1] = discipline;
        }

        public void RemoveDiscipline(string discipline)
        {
            for (int i = 0; i < disciplines.Length; i++)
            {
                if (disciplines[i] == discipline)
                {
                    disciplines[i] = disciplines[disciplines.Length - 1];
                    Array.Resize(ref disciplines, disciplines.Length - 1);
                    break;
                }
            }
        }

        public override string ToString()
        {
            string res = base.ToString() + " Disciplines: ";
            foreach (string item in disciplines)
            {
                res += $"{item}";
                if (item != disciplines[disciplines.Length - 1])
                    res += ", ";
            }
            return res;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
