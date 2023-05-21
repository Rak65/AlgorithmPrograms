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
        // Function to check if a number is prime
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            // Check divisibility from 2 to square root of the number
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Function to check if a number is an anagram
        public static bool IsAnagram(int number1, int number2)
        {
            string str1 = number1.ToString();
            string str2 = number2.ToString();

            // Convert the numbers to strings and sort the characters
            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Check if the sorted strings are equal
            string sortedStr1 = new string(charArray1);
            string sortedStr2 = new string(charArray2);

            return sortedStr1.Equals(sortedStr2);
        }

        // Function to check if a number is a palindrome
        public static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            int length = str.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Prime numbers in the range of 0 to 1000 that are anagrams and palindromes:");

            for (int i = 0; i <= 1000; i++)
            {
                if (IsPrime(i) && IsAnagram(i, 0) && IsPalindrome(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console .ReadKey();
        }
    }
}
