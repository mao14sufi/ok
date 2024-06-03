using System;

namespace l42
{
    public class Equation
    {
        public static int MyFunction(double a, double b, double c, ref double x1, ref double x2)
        {

            double d = Math.Pow(b, 2) - (4 * a * c);
            x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
            x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);

            if (d < 0)

                return -1;


            else if (d > 0)

                return 1;
            else
                           
                return 0;

           }
        }
             
            
                
                
                
               
                
    
            

          
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c : ");
            double c = double.Parse(Console.ReadLine());
            
               double x1 = 0;
               double x2 = 0;
            int solution = Equation.MyFunction(a, b, c,ref x1,ref x2);
        if (solution == -1)
            Console.WriteLine($"Equation with a={a:0.00} , b={b:0.00} and c={c:0.00} don't have solution.");
        else if (solution == 0)
            Console.WriteLine($"Equation with a={a:0.00} , b={b:0.00} and c={c:0.00} x1=x2= {x1:0.00}");
        else Console.WriteLine($"Equation with a={a:0.00} , b={b:0.00} and c={c:0.00} x1= {x1:0.00} and x2= {x2:0.00}");




        }
    }
}
