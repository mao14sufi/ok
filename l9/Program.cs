using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace la5
{
    interface IRotation
    {
        public void Rotate();
    }
    abstract class Shape
    {
        
        protected Shape(string name = "No name"  )
        {
            PetName = name;
        }

        public string PetName { get; set; }
        public override string ToString() => $"Figure: {PetName}";
        // A single virtual method.
        public virtual void Info()
        {
            Console.WriteLine($"Figure {this}");
        }
        public abstract double Area();
        public abstract double Perimetr(); 
    }
    class Circle : Shape, IRotation
       
    {
        private double radius;
        public Circle(string name, double Radius) : base(name)
        {
            this.radius = Radius;
        }
        public override double Area()
        {
            return  Math.Pow(radius, 2)*double.Pi;  
        }
        public override double Perimetr()
        {
            return 2*double.Pi*radius;
        }
        public override string ToString() => $"Circle '{PetName}' with radius = {radius} ";

        public void Rotate()
        {
            Console.WriteLine("Rotation");
        }


    }

    class Square : Shape, IRotation
    {
        private double side;
        public Square(string name, double Side) : base(name)
        {
            this.side = Side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimetr()
        {
            return 4 * side;
        }
        public override string ToString() => $"Square '{PetName}' with side = {side} ";
        public void Rotate()
        {
            Console.WriteLine("Rotation");
        }



    }




    class Triangle: Shape , IComparable<Triangle>
    {
        private double a, b, c;

        public Triangle(string name,double x, double y, double z) : base(name)
        {
            a = x;
            b = y;
            c = z;
        }

        public Triangle(string name,double x): base (name) 

        {
            a = x;
            b = x;
            c = x;
        }    

        public override double Perimetr()
        {
            return a + b + c;
        }

        public override double Area()
        {
            double p = Perimetr() / 2;

            if ( double.IsNaN (Math.Sqrt(p * (p - a) * (p - b) * (p - c))))
                return 0;
            else           
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        


        }
        public override string ToString() => $"Triangle '{PetName}' with sides a = {a}, b = {b} and c = {c}";
        
        public void CheckTriangle()
        {
            
            if (Area() > 0)
            {
                Console.WriteLine("Triangle exists");
            }
            else
                Console.WriteLine("Triangle does not exist");

        }
        

        public int CompareTo(Triangle t)
        {
            if (this.Area() == t.Area())
                return 0;
            else if (this.Area() > t.Area())
                return 1;
            else
                return -1;
        }
        
    }       

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] figures = {new Triangle ("first",10,9,8),new Circle("second",5),
            new Square("third",5), new Triangle ("equal",5)};
            
            foreach (var i in figures) 
            {
                
                i.Info();
                Console.WriteLine($"Area = {i.Area()}");
                Console.WriteLine($"Perimetr = {i.Perimetr()}\n");
                               
            }

            Circle s = new Circle("", 5);
            s.Rotate();
            
            

        }
    }
}
