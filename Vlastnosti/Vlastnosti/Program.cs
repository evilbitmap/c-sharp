using System;

namespace Vlastnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            data data = new data();
            data._x = input;

            Console.WriteLine("");
            Console.WriteLine(data._x);
            Console.WriteLine(data._y);
            data._string = data._string + "123";
            Console.WriteLine(data._string);

        }
    }
}
