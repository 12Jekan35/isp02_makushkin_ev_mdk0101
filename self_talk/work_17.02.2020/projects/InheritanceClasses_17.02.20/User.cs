using System;

namespace InheritanceClasses_17._02._20
{
    class User
    {
        protected string name;
        protected int age;

        public void GetName(string value)
        {
            name = value;
        }

        public string GetName()
        {
            return name;
        }

        public void GetAge(int value)
        {
            age = value;
        }

        public int GetAge()
        {
            return age;
        }

        public User(int age, string name)
        {
            GetAge(age);
            GetName(name);
        }
    }
}
