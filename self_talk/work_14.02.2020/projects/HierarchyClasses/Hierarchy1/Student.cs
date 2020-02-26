using System;

namespace HierarchyClasses.Hierarchy1
{
    class Student : Person
    {
        private int course;
        private string group;

        public Student(int course1, string group1, int age, string name)
            :base (age, name)
        {
            course = course1;
            group = group1;
        }
        public void NextCourse()
        {
            course++;
        }

        public override string ToString()
        {
            return base.ToString() + $"Course: {course} Group {group}";
        }
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
