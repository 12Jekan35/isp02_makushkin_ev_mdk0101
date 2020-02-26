using System;

namespace HierarchyClasses.Hierarchy1
{
    class Person
    {
        private int age;
        public int Age {set => age = value;}

        private string name;
        public string Name { set => name = value; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name: {name} Age: {age}";
        }
    }
}
