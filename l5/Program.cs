namespace l5
{   public class MyArray
    {
        public static void CreateArray(double[] A)
        {
            
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Enter array[{i}] :   ");
                A[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void OutArray(double[] A)
        { for (int i = 0;i < A.Length;i++)
            {
                Console.Write($"{A[i]} ");
            }

        }
        public static double SumArray(double[] A)
        {
            double sum = 0;
            for(int i = 0; i < A.Length; i++)
            {
                sum+= A[i];
            }
            return sum;
        }
        public static double MedianArray(double[] A)
        {
            double median = SumArray(A)/(A.Length);

            return median;
        }
        public static (double , double) SumWithSign(double[] A)
        {
            double sumWithMinus = 0 ;
            double sumWithPlus  = 0 ;
            for (int i = 0; i < A.Length ; i++)
            {
                
                if (A[i] < 0)
                {
                    sumWithMinus += A[i];
                }
                else
                {
                    sumWithPlus += A[i];
                }
               
            }
            return (sumWithMinus, sumWithPlus);
        }
        public static void Test()
        {
            double[] A = new double[5];
            MyArray.CreateArray(A);
            MyArray.OutArray(A);
            Console.WriteLine($"\nsum = {MyArray.SumArray(A)}");
            Console.WriteLine($"median = {MyArray.MedianArray(A)}");
            //(double sumWithMinus, double sumWithPlus) t = (0, 0);
            Console.WriteLine($"sum with minus = {MyArray.SumWithSign(A).Item1} and sum with plus = {MyArray.SumWithSign(A).Item2} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray.Test();
            
        }
    }
}
