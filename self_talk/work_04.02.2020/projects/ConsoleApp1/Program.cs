using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D vector1 = new Vector3D(2, 4, 6);
            Vector3D vector2 = new Vector3D(3, 6, 9);

            Console.WriteLine($"вектор 1: {vector1.ToString()}");
            Console.WriteLine($"вектор 2: {vector2.ToString()}");

            Console.WriteLine($"Длина 1 вектора: {vector1.VectorLength}");
            Console.WriteLine($"Длина 2 вектора: {vector2.VectorLength}");

            Console.WriteLine($"Скалярное произведение: {vector1.ScalarProduct(vector2)}");
            Console.WriteLine($"Векторное произведение: {(vector1.VectorProduct(vector2)).ToString()}");
        }
    }
}
