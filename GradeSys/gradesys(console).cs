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
            Console.Clear();
            bool isSubjectsEmpty = !subjects.Any();
            bool isGradesEmpty = !subjects.Any();

            if(isSubjectsEmpty)
            {
                Console.WriteLine("You have no subjects added");
                Console.WriteLine("Please add atleast one...");
                string input = Console.ReadLine();
                subjects.Add(input);
            }
            Console.Clear();

            if(isGradesEmpty)
            {
                Console.WriteLine("You have no grades in " + subjects[0]);
                Console.WriteLine("please add atleast one...");
                int input = Convert.ToInt32(Console.ReadLine());
                grades.Add(input);
            }
            Console.Clear();

            foreach (string item in subjects) // Loop through List with foreach
            {
                Console.WriteLine(item);
                AddPole();
            }

        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
