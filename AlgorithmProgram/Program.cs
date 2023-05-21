using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Test Binary Search
            int[] intArray = { 2, 4, 6, 8, 10 };
            int searchItem1 = 6;
            bool found1 = GenericSearchAndSort<int>.BinarySearch(intArray, searchItem1);
            Console.WriteLine("Binary Search - Found: " + found1);

            string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };
            string searchItem2 = "cherry";
            bool found2 = GenericSearchAndSort<string>.BinarySearch(stringArray, searchItem2);
            Console.WriteLine("Binary Search - Found: " + found2);

            // Test Bubble Sort
            double[] doubleArray = { 5.6, 1.2, 3.8, 2.1, 4.9 };
            GenericSearchAndSort<double>.BubbleSort(doubleArray);
            Console.WriteLine("Bubble Sort - Sorted Array:");
            foreach (double item in doubleArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
