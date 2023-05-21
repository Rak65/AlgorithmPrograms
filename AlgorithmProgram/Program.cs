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
        public static bool BinarySearch<T>(T[] words, T searchWord) where T : IComparable<T>
        {
            int left = 0;
            int right = words.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparison = searchWord.CompareTo(words[mid]);

                if (comparison == 0)
                {
                    return true; // Word found
                }
                else if (comparison < 0)
                {
                    right = mid - 1; // Search the left half
                }
                else
                {
                    left = mid + 1; // Search the right half
                }
            }

            return false; // Word not found
        }

        public static void Main(string[] args)
        {
                string[] words = { "Ram", "Mohan", "Ramesh", "Delhi", "Bangalore", "Mumbai" };

                // Sort the word list
                Array.Sort(words);

                // Prompt the user to enter a word to search
                Console.Write("Enter a word to search: ");
                string searchWord = Console.ReadLine();

                // Perform binary search
                bool isWordFound = BinarySearch(words, searchWord);

                // Print the result
                if (isWordFound)
                {
                    Console.WriteLine("Word found in the list.");
                }
                else
                {
                    Console.WriteLine("Word not found in the list.");
                }

            Console .ReadKey ();
        }
    }
}
