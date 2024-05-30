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
            
            double a = p / 3;
            double b = p / 3;
            double c = p / 3;

            double s = Math.Sqrt(p/2 * (p/2 - a) * (p/2 - b) * (p/2 - c));
            
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
