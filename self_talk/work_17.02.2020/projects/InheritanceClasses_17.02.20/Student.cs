using System;

namespace InheritanceClasses_17._02._20
{
    class Student: User
    {
        private double scholarship;
        private int course;

        public void SetSholarship(double value)
        {
            scholarship = value;
        }

        public double GetScholarship()
        {
            return scholarship;
        }

        public void SetCourse(int value)
        {
            course = value;
        }

        public int GetCourse()
        {
            return course;
        }

        public Student(int age, string name, int course, double scholarship)
            :base(age, name)
        {
            SetSholarship(scholarship);
            SetCourse(course);
        }
    }
}
