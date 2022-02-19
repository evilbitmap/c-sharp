using System;
using System.Collections.Generic;
using System.Linq;

namespace AddToArray
{
    class Program
    {
        static int[] Intarray = new int[] { };
        static List<int> Intlist = Intarray.ToList();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("int array: ");
                Console.WriteLine("");
                foreach (var e in Intarray)
                {
                    Console.Write(e + ", ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("> ");
                int value = Convert.ToInt32(Console.ReadLine());
                Intlist.Add(value);
                Intarray = Intlist.ToArray();
            }
        }
    }
}
