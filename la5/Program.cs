namespace la5
{
    public class Triangle
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
            return Math.Sqrt(p* (p - a) * (p - b) * (p - c));
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
            Console.WriteLine($"Triangle side a =  {a} , side b = {b}  , side c = {c} ");
        }

    }       

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides of triangle ");
            Triangle tr1 = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            
            tr1.CheckTriangle();
            Console.WriteLine($"perimetr of triangle = {tr1.Perimetr():0.00}");
            Console.WriteLine($"square of triangle = {tr1.Square():0.00}");
            tr1.OutTriangleSide();

        }
    }
}
