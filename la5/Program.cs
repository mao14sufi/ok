namespace la5
{
    public class Testing
    {
        public static void Test()
        {
            Console.WriteLine("Enter sides of triangle ");
            
            Triangle tr1 = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            tr1.CheckTriangle();
            Console.WriteLine($"perimetr of triangle = {tr1.Perimetr():0.00}");
            Console.WriteLine($"area of triangle = {tr1.Square():0.00}");
            tr1.OutTriangleSide();



        }
    }
    public class Triangle: IComparable<Triangle>
    {
        private double a, b, c;

        public Triangle(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }

        public double Perimetr()
        {
            return a + b + c;
        }

        public double Square()
        {
            double p = Perimetr() / 2;

            if ( double.IsNaN (Math.Sqrt(p * (p - a) * (p - b) * (p - c))))
                return 0;
            else           
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
             
            
        }
        public void CheckTriangle()
        {
            
            if (Square() > 0)
            {
                Console.WriteLine("Triangle exists");
            }
            else
                Console.WriteLine("Triangle does not exist");

        }
        public void OutTriangleSide()
        {
            Console.WriteLine($"Triangle with side a =  {a} , side b = {b}  , side c = {c} ");
        }

        public int CompareTo(Triangle t)
        {
            if (this.Square() == t.Square())
                return 0;
            else if (this.Square() > t.Square())
                return 1;
            else
                return -1;
        }
        
    }       

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Triangle[] triangles = new Triangle[3];

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine($"Enter sides of triangle {i+1} ");
                triangles[i] = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            }
            


            Array.Sort(triangles);

            foreach (Triangle tr in triangles)
            {
                Console.WriteLine();

                tr.CheckTriangle();
                tr.OutTriangleSide();

                Console.WriteLine($"area = {tr.Square():0.00}");
            }


            //Testing.Test();

            //Console.WriteLine("Enter sides of triangle ");
            //Triangle tr1 = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            //tr1.CheckTriangle();
            //Console.WriteLine($"perimetr of triangle = {tr1.Perimetr():0.00}");
            //Console.WriteLine($"square of triangle = {tr1.Square():0.00}");
            //tr1.OutTriangleSide();

        }
    }
}
