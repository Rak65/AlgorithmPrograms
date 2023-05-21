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
        // Merge Sort algorithm to sort a list
        public static void Sort<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count <= 1)
            {
                return;
            }

            int mid = list.Count / 2;
            List<T> left = new List<T>();
            List<T> right = new List<T>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }

            for (int i = mid; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            Sort(left);
            Sort(right);
            Merge(list, left, right);
        }

        private static void Merge<T>(List<T> mergedList, List<T> left, List<T> right) where T : IComparable<T>
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                {
                    mergedList[mergedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    mergedList[mergedIndex] = right[rightIndex];
                    rightIndex++;
                }

                mergedIndex++;
            }

            while (leftIndex < left.Count)
            {
                mergedList[mergedIndex] = left[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < right.Count)
            {
                mergedList[mergedIndex] = right[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }

        public static void Main(string[] args)
        {

            // Create a list of strings
            List<string> strings = new List<string>();

            // Prompt the user to enter the strings
            Console.WriteLine("Enter strings (one per line). Enter 'done' to finish.");
            string input;
            while ((input = Console.ReadLine()) != "done")
            {
                strings.Add(input);
            }

            // Sort the list using Merge Sort
            Sort(strings);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
