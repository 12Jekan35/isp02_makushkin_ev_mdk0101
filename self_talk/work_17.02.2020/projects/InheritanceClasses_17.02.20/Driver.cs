using System;

namespace InheritanceClasses_17._02._20
{
    class Driver: Worker
    {
        private int stage;
        private char category;

        public void SetStage(int value)
        {
            stage = value;
        }

        public int GetDStage()
        {
            return stage;
        }

        public void SetCategory(char value)
        {
            if (value != 'A' || value != 'B' || value != 'C')
                throw new Exception("Invalid value Driver category");
            else
                category = value;
        }

        public char GetCategoryDriver()
        {
            return category;
        }

        public Driver(int age, string name, double salary, int stage, char category)
            :base(age, name, salary)
        {
            SetCategory(category);
            SetStage(stage);
        }
    }
}
