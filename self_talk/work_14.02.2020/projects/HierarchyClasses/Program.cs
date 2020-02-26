using System;
using HierarchyClasses.Hierarchy1;

namespace HierarchyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {new Student(2, "ISP-02", 17, "Makushkin E.V."),
                               new Student(2, "ISP-01", 17, "Vasura K.A." ),
                               new Teacher(50, "Guslev M.V.", "MDK 01.01", "MDK 01.02", "Discrete Math"),
                               new Teacher(20, "Zhitkov N.S.", "AAS", "Computer's Network")};
            
            foreach (Person item in people)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
