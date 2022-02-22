using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Products.ProductCodes.hruska); // output: hruska

            Console.WriteLine((int)Products.ProductCodes.hruska); // output: 2 
            Console.WriteLine((int)Products.ProductCodes.mleko); // output: 0
            Console.WriteLine((int)Products.ProductCodes.NIC); // output: 0

            Console.WriteLine((Products.ProductCodes)3); // output: caj
        }
    }
}
