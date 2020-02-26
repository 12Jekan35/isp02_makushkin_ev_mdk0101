using System;

namespace Classes
{
    class Student
    {
        private int course;
        public readonly string Gender;

        public string Name { get; set;}
        
        public int Course
        {
            get => course;

            set
            {
                if (value < 1)
                    throw (new Exception("Enter invalid value"));
                else
                    course = value;
            }
        }

        public override string ToString()
        {
            string info = $"Course: {Course} " +
                          $"Name: {Name} " +
                          $"Gender: {Gender}";
            return info;
        }

        public Student(string gender, int course, string name)
        {
            Course = course;
            Name = name;
            Gender = gender;
        }
    }
}
