using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArr = RandomArr(/*Lenght*/ 50,/*Min number*/ 10,/*Max number*/ 100);
            int[] sortedArr = SortArr(RandomArr( 50, 10, 100));

            Console.WriteLine("Unsorted array:");
            foreach (int i in unsortedArr)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("");
            Console.WriteLine("--- --- --- --- --- ---");

            Console.WriteLine("Sorted array:");
            foreach (int i in sortedArr)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Search for number (sorted array): ");
            int toFind = Convert.ToInt32(Console.ReadLine());
            if (BinarySearch(sortedArr, 0, sortedArr.Length, toFind))
            {
                Console.WriteLine("");
                Console.WriteLine("Unsorted index: " + FindIndex(unsortedArr, toFind));
                Console.WriteLine("Sorted index: " + FindIndex(sortedArr, toFind));
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Not found");
            }
        }

        public static int[] SortArr(int[] array)
        {
            int lenght = array.Length;
            int temp = array[0];

            //First number in array
            for (int i = 0; i < lenght; i++)
            {
                //Next number from "i"
                for (int j = i+1; j < lenght; j++)
                {
                    //if the first number is bigger then the next one
                    if (array[i] > array[j])
                    {
                        //add first number to temp
                        temp = array[i];
                        //exchange values
                        array[i] = array[j];
                        //second number from array = number from temp
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static bool BinarySearch(int[] array, int left, int right, int target)
        {
            int middle = (left + right) / 2;
            if(left <= right)
            {
                if(array[middle] == target)
                {
                    return true;
                }
                if(array[middle] > target)
                {
                    return BinarySearch(array, left, middle - 1, target);
                }
                else
                    return BinarySearch(array, middle + 1, right, target);
            }
            return false;
        }

        public static int[] RandomArr(int lenght, int min, int max)
        {
            int[] arr = new int[lenght];
            Random rand = new Random();

           for (int i = 0; i < lenght; i++)
           {
                arr[i] = rand.Next(min, max);
           }
            return arr;
        }

        public static int FindIndex(int[] arr, int target)
        {
            if(arr == null)
                return -1;

            int lenght = arr.Length;
            int i = 0;
            while (i < lenght)
            {
                if(arr[i] == target)
                {
                    return i;
                }
                else
                {
                    i = i + 1;
                }
            }
            return -1;
        }
    }
}