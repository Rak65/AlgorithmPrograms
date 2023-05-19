using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Read the list of words from the user
            Console.WriteLine("Enter a list of words, separated by spaces:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            // Sort the words using insertion sort
            InsertionSortWords(words);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void InsertionSortWords<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                T key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key, to one position ahead
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }
        }
    }
}
