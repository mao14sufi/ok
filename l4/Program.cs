using System.Runtime.InteropServices;

namespace l4
{
    public class Operation
    { 

        public enum TypeTriangle { Equal, NotEqual}
       
        public static double HalfOfPerimetr(in double a,in double b,in double c)
        {
            return (a+b+c)/2; 
        }

       
    
        public static double TriangleSquare(in double a,in double b,in double c)
        {
            if (CheckTriangle(a, b, c))
            {
                double p = HalfOfPerimetr(a,b,c);

                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                return s;
            }
            else return -1;

        }
        public static double TriangleSquare(in double a)
        {
           
                double p = HalfOfPerimetr(a, a, a);

                double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));

                return s;
             
        }
         static bool CheckTriangle(in double a,in  double b,in double c)
        {  
            bool checkTriangle = false;
            double p = HalfOfPerimetr(a,b, c); 

            if ( Math.Sqrt(p * (p - a) * (p - b) * (p - c)) > 0)
                
                checkTriangle = true;

                 
            return checkTriangle;
        
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        { 
                Console.WriteLine("Enter type of triangle: ");
                Console.WriteLine("1.Equal");
                Console.WriteLine("2.Not equal");
                int type = int.Parse(Console.ReadLine());
                if (type == 1)
                {
                    Console.Write("Enter side of triangle ");
                    double a = double.Parse(Console.ReadLine());
                    double squareOfTriangle = Operation.TriangleSquare(a);
                    Console.WriteLine($"Square of triangle = {squareOfTriangle:0.00}");

                }




                else if (type == 2)
                {
                    Console.Write("Enter side a : ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter side b : ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter side c : ");
                    double c = double.Parse(Console.ReadLine());
                    double squareOfTriangle = Operation.TriangleSquare(a, b, c);
                    if (squareOfTriangle > 0)
                    {
                        Console.WriteLine($"Square of triangle = {squareOfTriangle:0.00}");
                    }
                    else
                    {
                        Console.WriteLine("Triangle does not exist ");
                    }

                }

           
            
            
        }
    }
}
