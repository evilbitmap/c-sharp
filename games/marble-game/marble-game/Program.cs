using System;

namespace marble_game
{
    class Program
    {
        public static int userPoints = 10;
        public static int randomWager = 0;
        public static string userInput;
        public static bool IsEven;
        static void instructions()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" A random wager will be generated from ");
            Console.WriteLine(" 1 to 6 .                              ");
            Console.WriteLine(" You will be given 10 points at start  ");
            Console.WriteLine(" and will have the option to choose    ");
            Console.WriteLine(" between odd and even.                 ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" If the wager will be the opposite to  ");
            Console.WriteLine(" your answer, you will lose the amount ");
            Console.WriteLine(" of wager. Your goal is to not have    ");
            Console.WriteLine(" 0 or less points. If you would like   ");
            Console.WriteLine(" abort the game, type 'exit'           ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("              Press any key to continue");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();

        }
        static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Points: {0}                  ", userPoints);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Wager: {0}", randomWager);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("You lost!");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void Abort()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("You have aborted the game!");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void GenerateRandomNumAndCheck()
        {
            Random rnd = new Random();
            randomWager = rnd.Next(1, 7);
        }

        static void check()
        {
            if (randomWager % 2 == 0)
            {
                IsEven = true;
            }
            else
            {
                IsEven = false;
            }
        }
        static void checkIfNumberIsLessThenZero()
        {
            if (userPoints <= 0)
            {
                GameOver();
            }
        }
    static void CalulatePoints()
        {
            if (userInput == "odd" && IsEven == false)
            {
                userPoints = userPoints + randomWager;
            }
            else if (userInput == "odd" && IsEven == true)
            {
                userPoints = userPoints - randomWager;
            }
            else if (userInput == "even" && IsEven == true)
            {
                userPoints = userPoints + randomWager;
            }
            else if (userInput == "even" && IsEven == false)
            {
                userPoints = userPoints - randomWager;
            }
        }
        static void game()
        {

            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Points: {0}                  ", userPoints);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Wager: {0}", randomWager);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("             odd or even?              ");
            userInput = Console.ReadLine();
            if (userInput == "exit")
            {
                Abort();
            }
            else if (userInput != "odd" && userInput != "even")
            {
                game();
            }
            GenerateRandomNumAndCheck();
            check();
            CalulatePoints();
            checkIfNumberIsLessThenZero();
            game();
        }
        static void Main(string[] args)
        {
            Console.Clear();
            instructions();
            game();
        }
    }
}
