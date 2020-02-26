using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student("Male", 1, "Иванов И.И.");
            Employee employee01 = new Employee("Петров П.П.", "Слесарь", 1);
            Workshop workshop01 = new Workshop("WS01", 5);
            string[] authors = { "Аркадий Стругацкий", "Борис Стругацкий" };
            Book book01 = new Book(authors, 2002, "Пикник на обочине");
            Credit credit01 = new Credit("Васильев В.В.", 5, "Сидоров К.А.");
            Address address01 = new Address(445501, "Волгоград", "Пушкина", "Колотушкина", 3);
            Product product01 = new Product(50, "Бомбастер", 5, 1000);
            EducationalGroup group01 = new EducationalGroup(19, "1-18", 2018, "ИСП");
            MonetaryNominal monetary01 = new MonetaryNominal("qwerty 12345", 10, "десять рублей");
            ComputerGame game01 = new ComputerGame("Dev01", "Action", 2000, "Untitle Game");

            Console.WriteLine("Student: " + student01.ToString() + "\n");
            Console.WriteLine("Employee: " + employee01.ToString() + "\n");
            Console.WriteLine("Workshop: " + workshop01.ToString() + "\n");
            Console.WriteLine("Book: " + book01.ToString() + "\n");
            Console.WriteLine("Credit: " + credit01.ToString() + "\n");
            Console.WriteLine("Address: " + address01.ToString() + "\n");
            Console.WriteLine("Product: " + product01.ToString() + "\n");
            Console.WriteLine("Educational Group: " + group01.ToString() + "\n");
            Console.WriteLine("Monetary Denomination: " + monetary01.ToString() + "\n");
            Console.WriteLine("Computer Game: " + game01.ToString() + "\n");

            Console.ReadKey();
        }
    }
}
