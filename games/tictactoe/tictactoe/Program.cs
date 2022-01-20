using System;
using System.Linq;
using System.Threading;

namespace tictactoe
{
    class Program
    {
        static int hracO_points;
        static int hracX_points;
        //pozice
        static char[] Pozice = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //kdo hraje
        static char Player = 'O';
        //input uživatele
        static int InputPozice;
        //něco na víc aby to vypadalo líp
        static string text;

        //printe hrací plochu
        static void Board()
        {
            Console.WriteLine("");
            Console.WriteLine(" +-----------+");
            Console.WriteLine(" | Points:   |");
            Console.WriteLine(" | O:{0} ; X:{1} |", hracO_points, hracX_points);
            Console.WriteLine(" +-----------+");
            Console.WriteLine("");
            Console.WriteLine("{0}", text);
            Console.WriteLine("");
            Console.WriteLine(" +-----+-----+");
            Console.WriteLine(" | {0} | {1} | {2} |", Pozice[6], Pozice[7], Pozice[8]);
            Console.WriteLine(" |---+---+---|");
            Console.WriteLine(" | {0} | {1} | {2} |", Pozice[3], Pozice[4], Pozice[5]);
            Console.WriteLine(" |---+---+---|");
            Console.WriteLine(" | {0} | {1} | {2} |", Pozice[0], Pozice[1], Pozice[2]);
            Console.WriteLine(" +-----+-----+");
            Console.WriteLine("");
            Console.WriteLine("Player's turn: {0}", Player);
        }
        static void hra()
        {
            while(true)
            {
                Console.Clear();
                text = "";
                Board();

                //input
                InputPozice = int.Parse(Console.ReadLine());

                //zkontroluje jestli je pole volné
                if(Pozice[InputPozice - 1] == ' ')
                {
                    Pozice[InputPozice - 1] = Player;
                }
                else
                {
                    Console.Clear();
                    text = "The spot is taken!";
                    Board();
                    Thread.Sleep(1000);
                }

                //zkontroluj výhru
                Pravidla();
                Zkontrolujvyherce();

                //vyměn hráče
                Changeplayer();
            }
        }
        public static void PlayAgain()
        {
            Console.Clear();
            Board();
            Console.WriteLine("Play again? (y/n)");
            string input = Console.ReadLine();
            if (input == "n")
            {
                Environment.Exit(0);
            }


        }
        public static void Zkontrolujvyherce()
        {
            if (Pravidla() == true)
            {
                Console.Clear();
                if (Player == 'O')
                {
                    text = "Player O won! (+1)";
                    hracO_points += 1;
                }
                else
                {
                    text = "Player X won! (+1)";
                    hracX_points += 1;
                }
                Board();
                Thread.Sleep(1000);
                PlayAgain();
                resetHraciPole();
            }
        }

        public static void Changeplayer()
        {
            if (Player == 'O')
            {
                Player = 'X';
            }
            else
            {
                Player = 'O';
            }
        }

        public static void resetHraciPole()
        {
            Pozice[0] = ' ';
            Pozice[1] = ' ';
            Pozice[2] = ' ';
            Pozice[3] = ' ';
            Pozice[4] = ' ';
            Pozice[5] = ' ';
            Pozice[6] = ' ';
            Pozice[7] = ' ';
            Pozice[8] = ' ';
        }


        //kopírováno, upraveno
        public static bool Pravidla()
        {
            // check rows
            if (Pozice[0] == 'O' && Pozice[1] == 'O' && Pozice[2] == 'O') { return true; }
            if (Pozice[3] == 'O' && Pozice[4] == 'O' && Pozice[5] == 'O') { return true; }
            if (Pozice[6] == 'O' && Pozice[7] == 'O' && Pozice[8] == 'O') { return true; }
            if (Pozice[0] == 'X' && Pozice[1] == 'X' && Pozice[2] == 'X') { return true; }
            if (Pozice[3] == 'X' && Pozice[4] == 'X' && Pozice[5] == 'X') { return true; }
            if (Pozice[6] == 'X' && Pozice[7] == 'X' && Pozice[8] == 'X') { return true; }

            // check columns
            if (Pozice[0] == 'O' && Pozice[3] == 'O' && Pozice[6] == 'O') { return true; }
            if (Pozice[1] == 'O' && Pozice[4] == 'O' && Pozice[7] == 'O') { return true; }
            if (Pozice[2] == 'O' && Pozice[5] == 'O' && Pozice[8] == 'O') { return true; }
            if (Pozice[0] == 'X' && Pozice[3] == 'X' && Pozice[6] == 'X') { return true; }
            if (Pozice[1] == 'X' && Pozice[4] == 'X' && Pozice[7] == 'X') { return true; }
            if (Pozice[2] == 'X' && Pozice[5] == 'X' && Pozice[8] == 'X') { return true; }


            // check diags
            if (Pozice[0] == 'O' && Pozice[4] == 'O' && Pozice[8] == 'O') { return true; }
            if (Pozice[2] == 'O' && Pozice[4] == 'O' && Pozice[6] == 'O') { return true; }
            if (Pozice[0] == 'X' && Pozice[4] == 'X' && Pozice[8] == 'X') { return true; }
            if (Pozice[2] == 'X' && Pozice[4] == 'X' && Pozice[6] == 'X') { return true; }

            return false;
        }


        static void Main(string[] args)
        {
            hra();
        }
    }
}
