using System;

namespace InheritanceClasses_17._02._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker01 = new Worker(25, "Иван", 1000);
            Worker worker02 = new Worker(26, "Вася", 2000);

            double sumSalaries = worker01.GetSalary() + worker02.GetSalary();

            Console.WriteLine($"Сумма зарплат составляет: {sumSalaries}");
            Console.ReadKey();
        }
    }
}
