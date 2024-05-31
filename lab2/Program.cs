namespace lab2
{
    public struct Distance
    {
       public int foot;
       public double inch;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Distance length1;
            Distance length2;
            Distance z;
            Console.Write("Enter foot1 ");
            length1.foot = int.Parse(Console.ReadLine());
            Console.Write("Enter inch1 ");
            length1.inch = Double.Parse(Console.ReadLine());
            Console.Write("Enter foot2 ");
            length2.foot = int.Parse(Console.ReadLine());
            Console.Write("Enter inch2 ");
            length2.inch = Double.Parse(Console.ReadLine());
            
            z.inch = (length1.inch + length2.inch) % 12;
            z.foot = length1.foot + length2.foot + (int)(length1.inch + length2.inch) / 12;

            
            
            Console.WriteLine($"Sum = {z.foot}'-{z.inch}'' ");
        }
    }
}
