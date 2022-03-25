using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToFind = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numbersToFindLength = numbersToFind.Length;
            int tofind = 2;

            if (BinarySearch(numbersToFind, 0, numbersToFindLength, tofind) != -1)
            {
                Console.WriteLine("found");
            }
            else
                Console.WriteLine("not found");

        }
        static int BinarySearch(int[] array, int left, int right, int target)
        {
            int middle = (left + right) / 2;

            //pokud leva cast bude mensi nez prava...
            if (left <= right)
            {
                //pokud prostredek se bude rovnat to co hledame
                //tak vrat hodnotu 1 (found)
                if (array[middle] == target)
                {
                    return 1;
                }

                //pokud stred bude vetsi nez co hledame
                if (array[middle] > target)
                {
                    //tak vrat pravou cast - 1
                    //protoze je to ta delka array
                    return BinarySearch(array, left, middle - 1, target);
                }
                //pokud naopak
                else
                    //tak pridej k leve casti + 1
                    //protoze to zacina od 0
                    return BinarySearch(array, middle + 1, right, target);
            }
            //pokud leva cast se bude rovnat prave casti
            //pointery jsou na stejnem miste
            //tak se nic nenaslo
            return -1;
        }
    }
}