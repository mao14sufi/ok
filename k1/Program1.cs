using System;

namespace k1
{/// <summary>
/// Вычисление площади s равноcтороннего треугольника с периметром p
/// </summary>
    class TriangleSquare
    {
        public static void MyMethod()
        {
            Console.WriteLine("Enter perimeter of triangle");

            double p = Double.Parse(Console.ReadLine());

            double s = Math.Sqrt((p / 2 * Math.Pow(p / 2 - p / 3, 3)));

            Console.WriteLine("Length \t Square");

            Console.WriteLine($"{p/3:0.00} \t {s:0.00}");

            




        }
    }
    
    
    
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleSquare.MyMethod(); 
        }
    }
}
