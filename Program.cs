using System;

namespace BasicPart10_ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {

            Square a = new Square();
            a.name = "Paper";
            a.SetDimension(8, 11);

            Square b = new Square();
            b.name = "KONGPOP";
            b.SetDimension(16, 9);

            Console.WriteLine("Object " + a.name + " has area = " + a.CalculateArea());
            Console.WriteLine("Object " + b.name + " has area = " + b.CalculateArea());

            Console.ReadKey();
        }
    }
}
