using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace pppppppp
{/// <summary>
 /// Вариант игры в кости
 /// </summary>

    interface IGetGUID
    {
        public void GetGUID();
    
    }


    class User : IGetGUID
    {
        protected string name;

        public User(string name)

        {
            this.name = name;
        }
        public string ReturnName() => name;
        public void GetGUID() 
        {
            Console.WriteLine(Guid.NewGuid().ToString());
        }
        


        
    }

    /// <summary>
    /// К классу User добавлен счет и методы:проверка на положительный баланс,
    /// пополнение выигрыша,снятие проигрыша
    /// </summary>


    class Player : User
    {

        
        private decimal account;

        public Player(string name, decimal account) : base(name)
        {
            this.account = account;
        }

        public override string ToString() => $"{name}\t{account}$";

               
        public void AddAccount(decimal bet)
        {
            this.account += bet;

        }
        public void SubtractAccount(decimal bet)
        {
            this.account -= bet;
        }



        public bool CheckCredibiity()
        {
            if (account > 0)
            {
                return true;
            }
            else return false;


        }

    }

    class Dice
    {
        private Random random = new Random();
        public int Move()
        {


            return random.Next(6) + 1;
        }


    }

    /// <summary>
    /// Игра в кость между двумя игроками без денег
    /// </summary>

     class Game
    {
        int numberofRound = 1;

        decimal bet=0 ;


        Dice dice1 = new Dice();


        protected Player p1;

        protected Player p2;


        public Game(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;




        }
        

        public virtual  void Begin()
        {
            Console.WriteLine($"BET={bet}$");
            Round();
            
        }




        public virtual void Round()
        {

            Console.WriteLine($"Round {numberofRound}   \n ");
            Console.WriteLine($"{p1.ReturnName()} VS {p2.ReturnName()}\n");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.Write("Press enter to move dice ");
            Console.ReadLine();

            int scorePlayer1 = dice1.Move();

            int scorePlayer2 = dice1.Move();


            Console.WriteLine($"{p1.ReturnName()} has {scorePlayer1} points - {p2.ReturnName()} has {scorePlayer2} points");

            GameLogic(scorePlayer1, scorePlayer2);





            Finish();


        }
        public void Finish()
        {
            Console.WriteLine($"");
            Console.WriteLine("Another round? y/n ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                numberofRound++;
                Begin();
            }
            else
            {
                Result();

            }
        }
        public void Result()

        {

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
        
        public virtual void GameLogic(int score1, int score2)
        {
            if (score1 < score2)
            {
               // p1.SubtractAccount(bet);
                //p2.AddAccount(bet);

                Console.WriteLine($"{p2.ReturnName()} win ");
            }
            else if (score1 > score2)
            {
                //p1.AddAccount(bet);
                //p2.SubtractAccount(bet);
                Console.WriteLine($"{p1.ReturnName()} win ");
            }
            else
            {
                Console.WriteLine("Draw");

            }
        }
    }
   /// <summary>
   /// В отличие от класса Game реализована игра на деньги, 
   /// игра заканчивается когда один  из игроков уходит в минус
   /// </summary>
    class GameWithMoney : Game
    {
        decimal bet;//Ставка в игре
        
        public GameWithMoney(Player p1, Player p2, decimal bet) : base (p1, p2)
        {
            this.bet = bet;

        }
        public override void Begin()
        {
            if (p1.CheckCredibiity() && p2.CheckCredibiity())
            {
                Console.WriteLine($"BET = {bet}$");
                Round();
            }
            else
            {
                Console.WriteLine("One player is default, game is over");
                Result();
            }
        }
        public override void GameLogic(int score1, int score2)
        {
            if (score1 < score2)
            {
                 p1.SubtractAccount(bet);
                p2.AddAccount(bet);

                Console.WriteLine($"{p2.ReturnName()} win {bet}$");
            }
            else if (score1 > score2)
            {
                p1.AddAccount(bet);
                p2.SubtractAccount(bet);
                Console.WriteLine($"{p1.ReturnName()} win {bet}$");
            }
            else
            {
                Console.WriteLine("Draw");

            }

        }
    }
       internal class Program
        {
            static void Main(string[] args)
            {
             Player p1 = new Player("victor", 20);// 20$ на счету игроков
             Player p2 = new Player("tom", 20);        
             Game game1 = new GameWithMoney(p1, p2, 50); // Игра между двумя игроками со ставкой 50$ 
             game1.Begin();

            //Game game2 = new Game(p1, p2); //Вариант без ставки
            //game2.Begin();







               
            }
        }

    
}
