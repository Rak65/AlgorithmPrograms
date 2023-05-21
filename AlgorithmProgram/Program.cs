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
        // Function to check if two strings are anagrams
        public static bool IsAnagram(string str1, string str2)
        {
            // Convert the strings to character arrays
            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            // Sort the character arrays
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Convert the sorted character arrays back to strings
            string sortedStr1 = new string(charArray1);
            string sortedStr2 = new string(charArray2);

            // Check if the sorted strings are equal
            return sortedStr1.Equals(sortedStr2);
        }

        public static void Main(string[] args)
        {

            // Prompt the user to enter two strings
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            // Check if the strings are anagrams
            bool isAnagram = IsAnagram(str1, str2);

            // Print the result
            if (isAnagram)
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
            Console .ReadKey();
        }
    }
}
