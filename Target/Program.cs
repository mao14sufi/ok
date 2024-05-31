namespace Target
{
    struct Point
    {
        public double x;
        public double y;
    }
    
    class Game
    {
        /// <summary>
    /// Метод возвращает количество набранных очков
    /// </summary>
    /// <returns></returns>
        public static int Shoottry()
        {
            int score = 0;
            double radius = 0;
            Point Shot;


            Console.Write("Enter coordinate X ");
            Shot.x = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y ");
            Shot.y = double.Parse(Console.ReadLine());


            radius = Math.Sqrt(Math.Pow(Shot.x, 2) + Math.Pow(Shot.y, 2));

            if (radius <= 1)
            {
                score = 10;
            }
            else if (radius <= 2)
            {
                score = 5;
            }
            return score;
        }

        /// <summary>
        /// Игра с 3 попытки
        /// </summary>        
        public static void ShootGame()
        {
            int result = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Shoot {i + 1}");
                result += Game.Shoottry();

            }



            Console.WriteLine($"Your score = {result}  !!!");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.ShootGame();
        }
    }
}
