using LibraryLists;
using System;
using System.Collections.Generic;

namespace ITEA_ListsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> array = new ArrayList<int>(new[] { 1, 100, 10, 44 });
            Console.WriteLine();
            //array.Sort();
            Console.WriteLine(array.IndexOf(10));
            //Console.WriteLine(array[2]);
            //array.RemoveAllItemsByValue("a");
            //Console.WriteLine(array.MinValueIndex());
            //array.Add(array);

            //array.AddFront(array);


            //array.InsertByIndex(array, 5);
            //array.AddFrontList(list);
            //array.AddListbyIndex(list, 2);

            //Console.WriteLine(array.MaxValueIndex());
            //array.Reverse();
            //array.AddFront(2);
            //new[] { 5, 6, 7, 8, 9, 10, 11 }

            //array.Sort();

            //array.RemoveAt(3);

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
        }


    }
}
