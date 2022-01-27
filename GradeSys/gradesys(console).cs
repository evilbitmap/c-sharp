using System;
using System.Collections.Generic;
using System.Linq;

namespace ZnamkyKal
{
    class Program
    {
        static string line1;
        static string line2;
        static string line3;
        static bool fastbool = true;
        static List<int> grades = new List<int>() {};
        static List<string> subjects = new List<string>();


        static void AddPole()
        {
            for(int i = 0; i < grades.Count; i++)
            {
                if (fastbool)
                {
                    line1 += "+---+";
                    line2 += "| " + grades[i] + " |";
                    line3 += "+---+";
                    fastbool = false;
                }
                else
                {
                   line1 += "---+";
                   line2 += " " + grades[i] + " |";
                   line3 += "---+";
                }
            }
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
        }

        static void MainMenu()
        {
            //main menu
            Console.WriteLine("1) Show grades");
            Console.WriteLine("2) EXIT");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    {
                        ShowGrades();
                        break;
                    }
                case 2:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        static void ShowGrades()
        {
            //zkontroluje jestli exituje nejaky subject a grades
            Console.Clear();
            bool isSubjectsEmpty = !subjects.Any();
            bool isGradesEmpty = !subjects.Any();

            if(isSubjectsEmpty)
            {
                Console.WriteLine("You have no subjects added");
                Console.WriteLine("Please add atleast one...");
                string input1 = Console.ReadLine();
                subjects.Add(input1);
            }
            Console.Clear();

            if(isGradesEmpty)
            {
                Console.WriteLine("You have no grades in " + subjects[0]);
                Console.WriteLine("please add atleast one...");
                int input2 = Convert.ToInt32(Console.ReadLine());
                grades.Add(input2);
            }

            //menu samo o sobe
            Console.Clear();
            Console.WriteLine("1) Add a grade");
            Console.WriteLine("2) Add a subject");
            Console.WriteLine("3) EXIT");
            Console.WriteLine("");

            //vypíše subjects a grades
            foreach (string item in subjects)
            {
                Console.WriteLine(item);
                AddPole();
            }

            //pro user input
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    {
                        AddGrade();
                        break;
                    }
                case 2:
                    {
                        AddSubject();
                        break;
                    }
                case 3:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        static void AddGrade()
        {
            Console.WriteLine("Choose a subject");
            foreach(string item in subjects)
            {
                Console.WriteLine(item);
            }
        }
        static void AddSubject()
        {
            Console.WriteLine("Enter name for subject");
            string input = Console.ReadLine();
            subjects.Add(input);
            ShowGrades();
        }


        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
